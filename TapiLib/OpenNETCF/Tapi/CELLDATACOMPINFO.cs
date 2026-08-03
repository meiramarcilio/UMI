namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct CELLDATACOMPINFO
    {
        public int dwDirection;
        public int dwRequired;
        public int dwMaxDictEntries;
        public int dwMaxStringLength;
    }
}

