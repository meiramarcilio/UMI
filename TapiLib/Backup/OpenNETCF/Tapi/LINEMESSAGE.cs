namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct LINEMESSAGE
    {
        public IntPtr hDevice;
        public LINEMESSAGES dwMessageID;
        public IntPtr dwCallbackInstance;
        public IntPtr dwParam1;
        public IntPtr dwParam2;
        public IntPtr dwParam3;
        public override string ToString()
        {
            switch (this.dwMessageID)
            {
                case LINEMESSAGES.LINE_CALLINFO:
                    return string.Format("{0}:{1}", this.dwMessageID, (LINECALLINFOSTATE) this.dwParam1.ToInt32());

                case LINEMESSAGES.LINE_CALLSTATE:
                    if (this.dwParam1.ToInt32() != 0x4000)
                    {
                        return string.Format("{0}:{1}", this.dwMessageID, (LINECALLSTATE) this.dwParam1.ToInt32());
                    }
                    return string.Format("{0}:{1}:{2}", this.dwMessageID, (LINECALLSTATE) this.dwParam1.ToInt32(), (LINEDISCONNECTMODE) this.dwParam2.ToInt32());

                case LINEMESSAGES.LINE_DEVSPECIFIC:
                {
                    LINEDEVSPECIFIC_CELLTSP linedevspecific_celltsp = (LINEDEVSPECIFIC_CELLTSP) this.dwParam1.ToInt32();
                    if (linedevspecific_celltsp == LINEDEVSPECIFIC_CELLTSP.LINE_EQUIPSTATECHANGE)
                    {
                        return string.Format("devspec:{0}:{1}", (LINEDEVSPECIFIC_CELLTSP) this.dwParam1.ToInt32(), (LINEEQUIPSTATE) this.dwParam2.ToInt32());
                    }
                    if (linedevspecific_celltsp != LINEDEVSPECIFIC_CELLTSP.LINE_REGISTERSTATE)
                    {
                        return string.Format("devspec:{0}", (LINEDEVSPECIFIC_CELLTSP) this.dwParam1.ToInt32());
                    }
                    return string.Format("devspec:{0}:{1}", (LINEDEVSPECIFIC_CELLTSP) this.dwParam1.ToInt32(), (LINEREGSTATUS) this.dwParam2.ToInt32());
                }
                case LINEMESSAGES.LINE_REPLY:
                    return string.Format("{0}:{1}", this.dwMessageID, this.dwParam1);
            }
            return this.dwMessageID.ToString();
        }
    }
}

