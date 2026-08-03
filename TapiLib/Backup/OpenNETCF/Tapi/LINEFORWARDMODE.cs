namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEFORWARDMODE
    {
        BUSY = 0x10,
        BUSYEXTERNAL = 0x40,
        BUSYINTERNAL = 0x20,
        BUSYNA = 0x1000,
        BUSYNAEXTERNAL = 0x4000,
        BUSYNAINTERNAL = 0x2000,
        BUSYNASPECIFIC = 0x8000,
        BUSYSPECIFIC = 0x80,
        NOANSW = 0x100,
        NOANSWEXTERNAL = 0x400,
        NOANSWINTERNAL = 0x200,
        NOANSWSPECIFIC = 0x800,
        UNAVAIL = 0x20000,
        UNCOND = 1,
        UNCONDEXTERNAL = 4,
        UNCONDINTERNAL = 2,
        UNCONDSPECIFIC = 8,
        UNKNOWN = 0x10000
    }
}

