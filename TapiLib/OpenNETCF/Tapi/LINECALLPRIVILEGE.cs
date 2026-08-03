namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINECALLPRIVILEGE
    {
        MONITOR = 2,
        NONE = 1,
        OWNER = 4
    }
}

