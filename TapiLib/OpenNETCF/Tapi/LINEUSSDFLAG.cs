namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEUSSDFLAG
    {
        ACTIONNOTNEEDED = 2,
        ACTIONREQUIRED = 1,
        ENDSESSION = 0x40,
        OTHERCLIENTRESPONDED = 8,
        TERMINATED = 4,
        TIMEOUT = 0x20,
        UNSUPPORTED = 0x10
    }
}

