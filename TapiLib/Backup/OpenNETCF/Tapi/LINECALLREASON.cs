namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINECALLREASON
    {
        CALLCOMPLETION = 0x80,
        CAMPEDON = 0x4000,
        DIRECT = 1,
        FWDBUSY = 2,
        FWDNOANSWER = 4,
        FWDUNCOND = 8,
        INTRUDE = 0x1000,
        PARKED = 0x2000,
        PICKUP = 0x10,
        REDIRECT = 0x40,
        REMINDER = 0x200,
        ROUTEREQUEST = 0x8000,
        TRANSFER = 0x100,
        UNAVAIL = 0x800,
        UNKNOWN = 0x400,
        UNPARK = 0x20
    }
}

