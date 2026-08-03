namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINESYSTEMTYPE
    {
        GPRS = 0x10,
        GSM = 8,
        IS95A = 1,
        IS95B = 2,
        NONE = 0,
        ONEXRTTPACKET = 4
    }
}

