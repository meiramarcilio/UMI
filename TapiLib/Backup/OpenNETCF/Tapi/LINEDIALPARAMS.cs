namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct LINEDIALPARAMS
    {
        public int dwDialPause;
        public int dwDialSpeed;
        public int dwDigitDuration;
        public int dwWaitForDialtone;
    }
}

