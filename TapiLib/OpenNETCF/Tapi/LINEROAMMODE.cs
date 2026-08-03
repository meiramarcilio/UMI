namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEROAMMODE
    {
        HOME = 4,
        ROAMA = 8,
        ROAMB = 0x10,
        UNAVAIL = 2,
        UNKNOWN = 1
    }
}

