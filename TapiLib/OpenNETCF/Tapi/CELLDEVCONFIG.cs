namespace OpenNETCF.Tapi
{
    using System;

    public class CELLDEVCONFIG : TapiStruct
    {
        public int bBearerInfoValid;
        public int bDataCompInfoValid;
        public int bGPRSConnectionInfoValid;
        public int bRadioLinkInfoValid;
        public CELLBEARERINFO cbiBearerInfo;
        public CELLDATACOMPINFO cdciDataCompInfo;
        public CELLGPRSCONNECTIONINFO cgciGPRSConnectionInfo;
        public CELLRADIOLINKINFO crliRadioLinkInfo;
        public int dwFlags;
        public int dwNeededSize;
        public int dwTotalSize;
        public int dwUsedSize;

        public CELLDEVCONFIG(int size) : base(size)
        {
            this.dwTotalSize = size;
        }
    }
}

