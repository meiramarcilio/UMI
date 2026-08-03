namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINECALLORIGIN
    {
        CONFERENCE = 0x40,
        EXTERNAL = 4,
        INBOUND = 0x80,
        INTERNAL = 2,
        OUTBOUND = 1,
        UNAVAIL = 0x20,
        UNKNOWN = 0x10
    }
}

