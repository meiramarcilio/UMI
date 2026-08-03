namespace OpenNETCF.Tapi
{
    using System;

    public class LINECALLLIST : TapiStruct
    {
        public int dwCallsNumEntries;
        public int dwCallsOffset;
        public int dwCallsSize;
        public int dwNeededSize;
        public int dwTotalSize;
        public int dwUsedSize;

        public LINECALLLIST(int size) : base(size)
        {
            this.dwTotalSize = size;
        }
    }
}

