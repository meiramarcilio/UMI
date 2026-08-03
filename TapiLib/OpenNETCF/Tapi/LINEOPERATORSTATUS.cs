namespace OpenNETCF.Tapi
{
    using System;

    public class LINEOPERATORSTATUS : TapiStruct
    {
        public int dwAvailableCount;
        public int dwAvailableOffset;
        public int dwAvailableSize;
        public int dwNeededSize;
        public int dwPreferredCount;
        public int dwPreferredOffset;
        public int dwPreferredSize;
        public int dwTotalSize;
        public int dwUsedSize;

        public LINEOPERATORSTATUS(int size) : base(size)
        {
            this.dwTotalSize = size;
        }
    }
}

