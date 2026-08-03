namespace OpenNETCF.Tapi
{
    using System;

    public class LINECALLSTATUS : TapiStruct
    {
        public LINECALLFEATURE dwCallFeatures;
        public LINECALLFEATURE2 dwCallFeatures2;
        public LINECALLPRIVILEGE dwCallPrivilege;
        public LINECALLSTATE dwCallState;
        public int dwCallStateMode;
        public int dwDevSpecificOffset;
        public int dwDevSpecificSize;
        public int dwNeededSize;
        public int dwTotalSize;
        public int dwUsedSize;
        public int StateEntryTimeHigh;
        public int StateEntryTimeLow;

        public LINECALLSTATUS(int size) : base(size)
        {
            this.dwTotalSize = size;
        }
    }
}

