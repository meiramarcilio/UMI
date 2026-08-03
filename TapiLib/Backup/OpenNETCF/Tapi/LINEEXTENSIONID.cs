namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct LINEEXTENSIONID
    {
        public IntPtr dwExtensionID0;
        public IntPtr dwExtensionID1;
        public IntPtr dwExtensionID2;
        public IntPtr dwExtensionID3;
    }
}

