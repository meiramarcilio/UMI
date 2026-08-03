namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEMEDIACONTROL
    {
        NONE = 1,
        PAUSE = 8,
        RATEDOWN = 0x40,
        RATENORMAL = 0x80,
        RATEUP = 0x20,
        RESET = 4,
        RESUME = 0x10,
        START = 2,
        VOLUMEDOWN = 0x200,
        VOLUMENORMAL = 0x400,
        VOLUMEUP = 0x100
    }
}

