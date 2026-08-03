namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct CELLGPRSCONNECTIONINFO
    {
        private const int CELLDEVCONFIG_MAXLENGTH_GPRSACCESSPOINTNAME = 0x40;
        private const int CELLDEVCONFIG_MAXLENGTH_GPRSADDRESS = 0x40;
        private const int CELLDEVCONFIG_MAXLENGTH_GPRSPARAMETERS = 0x20;
        public int dwProtocolType;
        public int dwL2ProtocolType;
        [Array(0x80)]
        public byte[] wszAccessPointName;
        [Array(0x80)]
        public byte[] wszAddress;
        public int dwDataCompression;
        public int dwHeaderCompression;
        [Array(0x40)]
        public byte[] szParameters;
        public int bRequestedQOSSettingsValid;
        public CELLGPRSQOSSETTINGS cgqsRequestedQOSSettings;
        public int bMinimumQOSSettingsValid;
        public CELLGPRSQOSSETTINGS cgqsMinimumQOSSettings;
    }
}

