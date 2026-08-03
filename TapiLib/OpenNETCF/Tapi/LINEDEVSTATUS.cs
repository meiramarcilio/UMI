namespace OpenNETCF.Tapi
{
    using System;

    public class LINEDEVSTATUS : TapiStruct
    {
        public int dwBatteryLevel;
        public int dwDevSpecificOffset;
        public int dwDevSpecificSize;
        public int dwDevStatusFlags;
        public LINEFEATURE dwLineFeatures;
        public int dwNeededSize;
        public int dwNumActiveCalls;
        public int dwNumCallCompletions;
        public int dwNumOnHoldCalls;
        public int dwNumOnHoldPendCalls;
        public int dwNumOpens;
        public int dwOpenMediaModes;
        public int dwRingMode;
        public LINEROAMMODE dwRoamMode;
        public int dwSignalLevel;
        public int dwTerminalModesOffset;
        public int dwTerminalModesSize;
        public int dwTotalSize;
        public int dwUsedSize;

        public LINEDEVSTATUS(int nSize) : base(nSize)
        {
            this.dwTotalSize = nSize;
        }
    }
}

