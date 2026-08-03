namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINECALLPARAMFLAGS
    {
        BLOCKID = 4,
        DESTOFFHOOK = 0x10,
        IDLE = 2,
        NOHOLDCONFERENCE = 0x20,
        ONESTEPTRANSFER = 0x80,
        ORIGOFFHOOK = 8,
        PREDICTIVEDIAL = 0x40,
        SECURE = 1
    }
}

