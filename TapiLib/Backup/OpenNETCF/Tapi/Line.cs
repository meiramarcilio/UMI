namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;

    public class Line : IDisposable
    {
        private bool bSyncMakeCall = false;
        private IntPtr m_hLine;
        private OpenNETCF.Tapi.Tapi tapi;

        public event NewCallHandler NewCall;

        internal Line(OpenNETCF.Tapi.Tapi t, IntPtr hLine)
        {
            this.tapi = t;
            this.m_hLine = hLine;
        }

        public IAsyncResult BeginMakeCall(string Destination, int CountryCode, byte[] Params, AsyncCallback Callback, object State)
        {
            this.bSyncMakeCall = false;
            MakeCallAsyncResult result = new MakeCallAsyncResult(0, Callback, State);
            lock (this.tapi.PendingRequests.SyncRoot)
            {
                int key = NativeTapi.lineMakeCall(this.m_hLine, out result.m_hCall, Destination, CountryCode, Params);
                result.ReplyID = key;
                if (key > 0)
                {
                    this.tapi.PendingRequests.Add(key, result);
                }
            }
            return result;
        }

        public void Dispose()
        {
            NativeTapi.lineClose(this.hLine);
            if (this.tapi.Lines.Contains(this.hLine))
            {
                this.tapi.Lines.Remove(this.hLine);
            }
        }

        public Call EndMakeCall(IAsyncResult ar)
        {
            MakeCallAsyncResult result = ar as MakeCallAsyncResult;
            if (result == null)
            {
                throw new ArgumentException("Invalid parameter", "ar");
            }
            if (!result.IsCompleted)
            {
                result.AsyncWaitHandle.WaitOne();
            }
            Call call = this.tapi.Calls[result.hCall] as Call;
            if (call == null)
            {
                call = new Call(result.m_hCall);
                this.tapi.Calls.Add(result.m_hCall, call);
                call.LoadCallInfo();
                call.LoadCallState();
            }
            return call;
        }

        public Call MakeCall(string Destination, int CountryCode, byte[] Params)
        {
            IAsyncResult ar = this.BeginMakeCall(Destination, CountryCode, Params, null, null);
            this.bSyncMakeCall = true;
            MakeCallAsyncResult result2 = ar as MakeCallAsyncResult;
            bool flag = false;
            while (!flag)
            {
                Monitor.Enter(result2);
                if (result2.IsCompleted)
                {
                    flag = true;
                }
                Monitor.Exit(result2);
                Application.DoEvents();
            }
            return this.EndMakeCall(ar);
        }

        public Call MakeCall(string Destination, int CountryCode, bool SupressCallerID)
        {
            byte[] params = null;
            if (SupressCallerID)
            {
                LINECALLPARAMS linecallparams = new LINECALLPARAMS(Marshal.SizeOf(typeof(LINECALLPARAMS)) + Marshal.SizeOf(typeof(LINECALLPARAMSDEVSPECIFIC)));
                linecallparams.dwDevSpecificOffset = Marshal.SizeOf(typeof(LINECALLPARAMS));
                linecallparams.dwDevSpecificSize = Marshal.SizeOf(typeof(LINECALLPARAMSDEVSPECIFIC));
                linecallparams.Store();
                LINECALLPARAMSDEVSPECIFIC source = new LINECALLPARAMSDEVSPECIFIC();
                source.cidoOptions = CALLER_ID_OPTIONS.BLOCK;
                int dwDevSpecificOffset = linecallparams.dwDevSpecificOffset;
                ByteCopy.StructToByteArray(source, ref dwDevSpecificOffset, linecallparams.Data);
                params = linecallparams.Data;
            }
            return this.MakeCall(Destination, CountryCode, params);
        }

        internal void MakeCallCallback(IAsyncResult ar)
        {
        }

        protected internal void OnNewCall(Call call)
        {
            if ((this.NewCall != null) && !this.bSyncMakeCall)
            {
                this.NewCall(call);
            }
        }

        public IntPtr hLine
        {
            get
            {
                return this.m_hLine;
            }
        }

        public delegate void NewCallHandler(Call call);
    }
}

