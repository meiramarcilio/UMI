namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINECALLINFOSTATE
    {
        APPSPECIFIC = 0x20,
        BEARERMODE = 4,
        CALLDATA = 0x40000000,
        CALLEDID = 0x10000,
        CALLERID = 0x8000,
        CALLID = 0x40,
        CHARGINGINFO = 0x1000000,
        COMPLETIONID = 0x400,
        CONNECTEDID = 0x20000,
        DEVSPECIFIC = 2,
        DIALPARAMS = 0x4000000,
        DISPLAY = 0x100000,
        HIGHLEVELCOMP = 0x400000,
        LOWLEVELCOMP = 0x800000,
        MEDIAMODE = 0x10,
        MONITORMODES = 0x8000000,
        NUMMONITORS = 0x2000,
        NUMOWNERDECR = 0x1000,
        NUMOWNERINCR = 0x800,
        ORIGIN = 0x100,
        OTHER = 1,
        QOS = 0x20000000,
        RATE = 8,
        REASON = 0x200,
        REDIRECTINGID = 0x80000,
        REDIRECTIONID = 0x40000,
        RELATEDCALLID = 0x80,
        TERMINAL = 0x2000000,
        TREATMENT = 0x10000000,
        TRUNK = 0x4000,
        USERUSERINFO = 0x200000
    }
}

