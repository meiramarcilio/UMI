namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINECAPSCLASS
    {
        ALL = 0xff,
        ASYNCDATA = 0x20,
        DATA = 2,
        FAX = 4,
        PACKET = 0x40,
        PAD = 0x80,
        SMS = 8,
        SYNCDATA = 0x10,
        VOICE = 1
    }
}

