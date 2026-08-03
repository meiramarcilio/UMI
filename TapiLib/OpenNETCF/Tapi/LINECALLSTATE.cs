namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINECALLSTATE
    {
        ACCEPTED = 4,
        BUSY = 0x40,
        CONFERENCED = 0x800,
        CONNECTED = 0x100,
        DIALING = 0x10,
        DIALTONE = 8,
        DISCONNECTED = 0x4000,
        IDLE = 1,
        OFFERING = 2,
        ONHOLD = 0x400,
        ONHOLDPENDCONF = 0x1000,
        ONHOLDPENDTRANSFER = 0x2000,
        PROCEEDING = 0x200,
        RINGBACK = 0x20,
        SPECIALINFO = 0x80,
        UNKNOWN = 0x8000
    }
}

