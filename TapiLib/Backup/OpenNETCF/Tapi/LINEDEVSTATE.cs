namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEDEVSTATE
    {
        BATTERY = 0x8000,
        CAPSCHANGE = 0x100000,
        CLOSE = 0x400,
        COMPLCANCEL = 0x800000,
        CONFIGCHANGE = 0x200000,
        CONNECTED = 4,
        DEVSPECIFIC = 0x20000,
        DISCONNECTED = 8,
        INSERVICE = 0x40,
        LOCK = 0x80000,
        MAINTENANCE = 0x100,
        MSGWAITOFF = 0x20,
        MSGWAITON = 0x10,
        NUMCALLS = 0x800,
        NUMCOMPLETIONS = 0x1000,
        OPEN = 0x200,
        OTHER = 1,
        OUTOFSERVICE = 0x80,
        REINIT = 0x40000,
        REMOVED = 0x1000000,
        RINGING = 2,
        ROAMMODE = 0x4000,
        SIGNAL = 0x10000,
        TERMINALS = 0x2000,
        TRANSLATECHANGE = 0x400000
    }
}

