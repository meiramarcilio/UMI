namespace OpenNETCF.Tapi
{
    using System;

    public class VARSTRING : TapiStruct
    {
        public int dwNeededSize;
        public int dwStringFormat;
        public int dwStringOffset;
        public int dwStringSize;
        public int dwTotalSize;
        public int dwUsedSize;

        public VARSTRING(int size) : base(size)
        {
            this.dwTotalSize = size;
        }
    }
}

