namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEDEVCAPFLAGS
    {
        CALLHUB = 0x400,
        CALLHUBTRACKING = 0x800,
        CLOSEDROP = 0x20,
        CROSSADDRCONF = 1,
        DIALBILLING = 0x40,
        DIALDIALTONE = 0x100,
        DIALQUIET = 0x80,
        HIGHLEVCOMP = 2,
        LOWLEVCOMP = 4,
        MEDIACONTROL = 8,
        MSP = 0x200,
        MULTIPLEADDR = 0x10,
        PRIVATEOBJECTS = 0x1000
    }
}

