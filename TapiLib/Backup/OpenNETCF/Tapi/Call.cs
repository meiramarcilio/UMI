namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;

    public class Call : IDisposable
    {
        internal int m_addressID;
        private string m_callerID = "";
        private IntPtr m_hCall;
        private LINECALLINFO m_info;
        internal OpenNETCF.Tapi.Line m_line;
        private LINECALLSTATE m_state;

        public event CallInfoHandler CallInfo;

        public event CallStateHandler CallState;

        internal Call(IntPtr hCall)
        {
            this.m_hCall = hCall;
            this.m_info = new LINECALLINFO(Marshal.SizeOf(typeof(LINECALLINFO)));
        }

        public void Dispose()
        {
        }

        public void Hangup()
        {
            NativeTapi.lineDrop(this.m_hCall, null, 0);
        }

        protected internal void LoadCallInfo()
        {
            this.m_info = new LINECALLINFO(0x400);
            this.m_info.Store();
            int err = NativeTapi.lineGetCallInfo(this.m_hCall, this.m_info.Data);
            this.m_info.Load();
            if (err < 0)
            {
                throw new TapiException(err);
            }
        }

        protected internal void LoadCallState()
        {
            LINECALLSTATUS linecallstatus = new LINECALLSTATUS(0x400);
            linecallstatus.Store();
            int err = NativeTapi.lineGetCallStatus(this.m_hCall, linecallstatus.Data);
            linecallstatus.Load();
            if (err < 0)
            {
                throw new TapiException(err);
            }
            this.m_state = linecallstatus.dwCallState;
        }

        protected internal void OnLineCallInfo(LINEMESSAGE msg)
        {
            LINECALLINFOSTATE linecallinfostate = (LINECALLINFOSTATE) msg.dwParam1.ToInt32();
            this.LoadCallInfo();
            if (((linecallinfostate & LINECALLINFOSTATE.CALLERID) == LINECALLINFOSTATE.CALLERID) && (this.m_info.dwCallerIDSize != 0))
            {
                this.m_callerID = Encoding.Unicode.GetString(this.m_info.Data, this.m_info.dwCallerIDOffset, this.m_info.dwCallerIDSize - 1);
            }
            if (this.CallInfo != null)
            {
                this.CallInfo(this, (LINECALLINFOSTATE) msg.dwParam1.ToInt32(), this.m_info);
            }
        }

        protected internal void OnLineCallState(LINEMESSAGE msg)
        {
            this.m_state = (LINECALLSTATE) msg.dwParam1.ToInt32();
            if (this.CallState != null)
            {
                this.CallState(this, this.m_state);
            }
        }

        protected internal void OnLineMonitorTones(LINEMESSAGE msg)
        {
        }

        public int AddressID
        {
            get
            {
                return this.m_addressID;
            }
        }

        public string CallerID
        {
            get
            {
                return this.m_callerID;
            }
        }

        public LINECALLINFO Info
        {
            get
            {
                return this.m_info;
            }
        }

        public OpenNETCF.Tapi.Line Line
        {
            get
            {
                return this.m_line;
            }
        }

        public LINECALLSTATE State
        {
            get
            {
                return this.m_state;
            }
        }

        public delegate void CallInfoHandler(Call call, LINECALLINFOSTATE infoState, LINECALLINFO info);

        public delegate void CallStateHandler(Call call, LINECALLSTATE state);
    }
}

