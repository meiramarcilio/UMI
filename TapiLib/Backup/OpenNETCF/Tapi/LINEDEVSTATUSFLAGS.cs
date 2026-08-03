namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEDEVSTATUSFLAGS
    {
        CONNECTED = 1,
        INSERVICE = 4,
        LOCKED = 8,
        MSGWAIT = 2
    }
}

