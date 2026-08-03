namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct LINECALLPARAMSDEVSPECIFIC
    {
        public CALLER_ID_OPTIONS cidoOptions;
    }
}

