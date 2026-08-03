namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEBARRMODE
    {
        ALL = 0x40,
        ALL_IN = 0x100,
        ALL_OUT = 0x80,
        IN = 8,
        IN_NOTINSIM = 0x20,
        IN_ROAM = 0x10,
        OUT = 1,
        OUT_INT = 2,
        OUT_INTEXTOHOME = 4
    }
}

