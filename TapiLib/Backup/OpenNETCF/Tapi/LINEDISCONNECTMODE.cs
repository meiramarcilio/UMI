namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEDISCONNECTMODE
    {
        BADADDRESS = 0x80,
        BLOCKED = 0x20000,
        BUSY = 0x20,
        CANCELLED = 0x80000,
        CONGESTION = 0x200,
        DONOTDISTURB = 0x40000,
        EMERGENCYONLY = 0xd40001,
        FORWARDED = 0x10,
        INCOMPATIBLE = 0x400,
        INVALIDSIMCARD = 0xd10001,
        NETWORKSERVICENOTAVAILABLE = 0xd30001,
        NOANSWER = 0x40,
        NODIALTONE = 0x1000,
        NORMAL = 1,
        NUMBERCHANGED = 0x2000,
        OUTOFORDER = 0x4000,
        PHONECONNECTIONFAILURE = 0xd00001,
        PICKUP = 8,
        QOSUNAVAIL = 0x10000,
        REJECT = 4,
        SIMCARDBUSY = 0xd20001,
        TEMPFAILURE = 0x8000,
        UNAVAIL = 0x800,
        UNKNOWN = 2,
        UNREACHABLE = 0x100
    }
}

