namespace OpenNETCF.Tapi
{
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;

    public class Tapi
    {
        internal Hashtable Calls = new Hashtable();
        public int dwAPIVersionHigh = 0x20000;
        public int dwAPIVersionLow = 0x10004;
        private int dwNumDev;
        private IntPtr hEvent = IntPtr.Zero;
        internal Hashtable Lines = new Hashtable();
        private IntPtr m_hLineApp;
        internal Hashtable PendingRequests = new Hashtable();
        private bool stop = false;
        private Thread thTapi;

        public event MessageHandler LineMessage;

        public event ReinitializeHandler Reinitialize;

        public Line CreateLine(int deviceID, LINEMEDIAMODE mode, LINECALLPRIVILEGE priv)
        {
            IntPtr ptr;
            int err = NativeTapi.lineOpen(this.m_hLineApp, deviceID, out ptr, this.NegotiateVersion(deviceID), 0, IntPtr.Zero, priv, mode, IntPtr.Zero);
            if (err != 0)
            {
                throw new TapiException(err);
            }
            Line line = new Line(this, ptr);
            this.Lines.Add(ptr, line);
            return line;
        }

        public LINEERR GetDevCaps(int deviceID, out LINEDEVCAPS dc)
        {
            dc = new LINEDEVCAPS(0x400);
            dc.Store();
            int num = NativeTapi.lineGetDevCaps(this.m_hLineApp, deviceID, this.NegotiateVersion(deviceID), 0, dc.Data);
            dc.Load();
            if (num == -2147483571)
            {
                dc = new LINEDEVCAPS(dc.dwNeededSize);
                num = NativeTapi.lineGetDevCaps(this.m_hLineApp, deviceID, this.NegotiateVersion(deviceID), 0, dc.Data);
                dc.Load();
            }
            return (LINEERR) num;
        }

        public int Initialize()
        {
            int lpdwAPIVersion = 0x20000;
            LINEINITIALIZEEXPARAMS lpLineInitializeExParams = new LINEINITIALIZEEXPARAMS(this.hEvent);
            int err = NativeTapi.lineInitializeEx(out this.m_hLineApp, IntPtr.Zero, IntPtr.Zero, "MyApp", out this.dwNumDev, ref lpdwAPIVersion, lpLineInitializeExParams);
            if (err != 0)
            {
                throw new TapiException(err);
            }
            this.thTapi = new Thread(new ThreadStart(this.TapiThreadProc));
            this.thTapi.Start();
            return err;
        }

        public int NegotiateVersion(int deviceID)
        {
            int num;
            LINEEXTENSIONID lineextensionid;
            int err = NativeTapi.lineNegotiateAPIVersion(this.m_hLineApp, deviceID, this.dwAPIVersionLow, this.dwAPIVersionHigh, out num, out lineextensionid);
            if (err != 0)
            {
                throw new TapiException(err);
            }
            return num;
        }

        private void OnLineCallInfo(LINEMESSAGE msg)
        {
            bool flag = false;
            if (!this.Calls.Contains(msg.hDevice))
            {
                this.Calls.Add(msg.hDevice, new Call(msg.hDevice));
                flag = true;
            }
            if (this.Calls.Contains(msg.hDevice))
            {
                Call call = this.Calls[msg.hDevice] as Call;
                call.OnLineCallInfo(msg);
                if (call.m_line == null)
                {
                    Line line = this.Lines[call.Info.hLine] as Line;
                    call.m_line = line;
                    if (flag && (line != null))
                    {
                        line.OnNewCall(call);
                    }
                }
            }
        }

        private void OnLineCallState(LINEMESSAGE msg)
        {
            bool flag = false;
            if (!this.Calls.Contains(msg.hDevice))
            {
                this.Calls.Add(msg.hDevice, new Call(msg.hDevice));
                flag = true;
            }
            if (this.Calls.Contains(msg.hDevice))
            {
                Call call = this.Calls[msg.hDevice] as Call;
                call.OnLineCallState(msg);
                if (flag)
                {
                    call.LoadCallInfo();
                    Line line = this.Lines[call.Info.hLine] as Line;
                    call.m_line = line;
                    if (line != null)
                    {
                        line.OnNewCall(call);
                    }
                }
            }
        }

        protected void OnLineClose(LINEMESSAGE msg)
        {
            IntPtr hDevice = msg.hDevice;
            Line line = this.Lines[hDevice] as Line;
            if (line != null)
            {
                line.Dispose();
            }
        }

        protected void OnLineReinit()
        {
            this.Shutdown();
            this.Lines.Clear();
            this.Calls.Clear();
            this.PendingRequests.Clear();
            this.Initialize();
            if (this.Reinitialize != null)
            {
                this.Reinitialize();
            }
        }

        protected void OnLineReply(LINEMESSAGE msg)
        {
            lock (this.PendingRequests.SyncRoot)
            {
                object obj2 = this.PendingRequests[(int) msg.dwParam1];
                if (obj2 != null)
                {
                    if (obj2 is MakeCallAsyncResult)
                    {
                        ((obj2 as MakeCallAsyncResult).AsyncWaitHandle as ManualResetEvent).Set();
                        if ((obj2 as MakeCallAsyncResult).Callback != null)
                        {
                            (obj2 as MakeCallAsyncResult).Callback(obj2 as IAsyncResult);
                        }
                    }
                    this.PendingRequests.Remove((int) msg.dwParam1);
                }
            }
        }

        protected void OnMessage(LINEMESSAGE msg)
        {
            if (this.LineMessage != null)
            {
                this.LineMessage(msg);
            }
        }

        private void OnNewCall(LINEMESSAGE msg)
        {
            bool flag = false;
            if (!this.Calls.Contains(msg.dwParam2))
            {
                this.Calls.Add(msg.dwParam2, new Call(msg.dwParam2));
                flag = true;
            }
            if (this.Calls.Contains(msg.dwParam2))
            {
                Call call = this.Calls[msg.dwParam2] as Call;
                call.m_addressID = msg.dwParam1.ToInt32();
                if (call.m_line == null)
                {
                    Line line = this.Lines[msg.hDevice] as Line;
                    call.m_line = line;
                    if (flag && (line != null))
                    {
                        line.OnNewCall(call);
                    }
                }
            }
        }

        public void Shutdown()
        {
            object[] array = new object[this.Calls.Values.Count];
            this.Calls.Values.CopyTo(array, 0);
            foreach (Call call in array)
            {
                call.Dispose();
            }
            array = new object[this.Lines.Values.Count];
            this.Lines.Values.CopyTo(array, 0);
            foreach (Line line in array)
            {
                line.Dispose();
            }
            this.stop = true;
            NativeTapi.lineShutdown(this.m_hLineApp);
        }

        private void TapiThreadProc()
        {
            while (!this.stop)
            {
                LINEMESSAGE linemessage;
                if (NativeTapi.lineGetMessage(this.m_hLineApp, out linemessage, -1) == 0)
                {
                    this.OnMessage(linemessage);
                    switch (linemessage.dwMessageID)
                    {
                        case LINEMESSAGES.LINE_CALLINFO:
                        {
                            this.OnLineCallInfo(linemessage);
                            continue;
                        }
                        case LINEMESSAGES.LINE_CALLSTATE:
                        {
                            this.OnLineCallState(linemessage);
                            continue;
                        }
                        case LINEMESSAGES.LINE_CLOSE:
                        {
                            this.OnLineClose(linemessage);
                            continue;
                        }
                        case LINEMESSAGES.LINE_REPLY:
                            goto Label_005C;

                        case LINEMESSAGES.LINE_APPNEWCALL:
                            goto Label_0065;
                    }
                }
                continue;
            Label_005C:
                this.OnLineReply(linemessage);
                continue;
            Label_0065:
                this.OnNewCall(linemessage);
            }
        }

        public IntPtr hLineApp
        {
            get
            {
                return this.m_hLineApp;
            }
        }

        public int NumDevices
        {
            get
            {
                return this.dwNumDev;
            }
        }

        public delegate void MessageHandler(LINEMESSAGE msg);

        public delegate void ReinitializeHandler();
    }
}

