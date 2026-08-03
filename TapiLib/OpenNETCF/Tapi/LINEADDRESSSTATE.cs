namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEADDRESSSTATE
    {
        CAPSCHANGE = 0x100,
        DEVSPECIFIC = 2,
        FORWARD = 0x40,
        INUSEMANY = 0x10,
        INUSEONE = 8,
        INUSEZERO = 4,
        NUMCALLS = 0x20,
        OTHER = 1,
        TERMINALS = 0x80
    }
}

