namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct CELLRADIOLINKINFO
    {
        public int dwVersion;
        public int dwIws;
        public int dwMws;
        public int dwAckTimer;
        public int dwRetransmitAttempts;
        public int dwResequenceTimer;
    }
}

