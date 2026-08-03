namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEFEATURE
    {
        DEVSPECIFIC = 1,
        DEVSPECIFICFEAT = 2,
        FORWARD = 4,
        FORWARDDND = 0x100,
        FORWARDFWD = 0x80,
        MAKECALL = 8,
        SETDEVSTATUS = 0x40,
        SETMEDIACONTROL = 0x10,
        SETTERMINAL = 0x20
    }
}

