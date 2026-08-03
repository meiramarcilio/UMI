namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct CELLBEARERINFO
    {
        public CELLDEVCONFIG_SPEED dwSpeed;
        public int dwService;
        public int dwConnectionElement;
    }
}

