namespace OpenNETCF.Tapi
{
    using System;

    public class LINECALLPARAMS : TapiStruct
    {
        public LINEDIALPARAMS DialParams;
        public int dwAddressID;
        public LINEADDRESSMODE dwAddressMode;
        public int dwAddressType;
        public LINEBEARERMODE dwBearerMode;
        public int dwCallDataOffset;
        public int dwCallDataSize;
        public int dwCalledPartyOffset;
        public int dwCalledPartySize;
        public int dwCallingPartyIDOffset;
        public int dwCallingPartyIDSize;
        public LINECALLPARAMFLAGS dwCallParamFlags;
        public int dwCommentOffset;
        public int dwCommentSize;
        public int dwDeviceClassOffset;
        public int dwDeviceClassSize;
        public int dwDeviceConfigOffset;
        public int dwDeviceConfigSize;
        public int dwDevSpecificOffset;
        public int dwDevSpecificSize;
        public int dwDisplayableAddressOffset;
        public int dwDisplayableAddressSize;
        public int dwHighLevelCompOffset;
        public int dwHighLevelCompSize;
        public int dwLowLevelCompOffset;
        public int dwLowLevelCompSize;
        public int dwMaxRate;
        public LINEMEDIAMODE dwMediaMode;
        public int dwMinRate;
        public int dwNoAnswerTimeout;
        public int dwOrigAddressOffset;
        public int dwOrigAddressSize;
        public int dwPredictiveAutoTransferStates;
        public int dwReceivingFlowspecOffset;
        public int dwReceivingFlowspecSize;
        public int dwSendingFlowspecOffset;
        public int dwSendingFlowspecSize;
        public int dwTargetAddressOffset;
        public int dwTargetAddressSize;
        public int dwTotalSize;
        public int dwUserUserInfoOffset;
        public int dwUserUserInfoSize;

        public LINECALLPARAMS(int size) : base(size)
        {
            this.dwTotalSize = size;
        }
    }
}

