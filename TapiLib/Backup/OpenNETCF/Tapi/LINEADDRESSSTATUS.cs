namespace OpenNETCF.Tapi
{
    using System;

    public class LINEADDRESSSTATUS : TapiStruct
    {
        public int dwAddressFeatures;
        public int dwDevSpecificOffset;
        public int dwDevSpecificSize;
        public int dwForwardNumEntries;
        public int dwForwardOffset;
        public int dwForwardSize;
        public int dwNeededSize;
        public int dwNumActiveCalls;
        public int dwNumInUse;
        public int dwNumOnHoldCalls;
        public int dwNumOnHoldPendCalls;
        public int dwNumRingsNoAnswer;
        public int dwTerminalModesOffset;
        public int dwTerminalModesSize;
        public int dwTotalSize;
        public int dwUsedSize;

        public LINEADDRESSSTATUS(int size) : base(size)
        {
            this.dwTotalSize = size;
        }
    }
}

