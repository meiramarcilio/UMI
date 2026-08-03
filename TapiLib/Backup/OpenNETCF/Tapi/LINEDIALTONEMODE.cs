namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEDIALTONEMODE
    {
        EXTERNAL = 8,
        INTERNAL = 4,
        NORMAL = 1,
        SPECIAL = 2,
        UNAVAIL = 0x20,
        UNKNOWN = 0x10
    }
}

