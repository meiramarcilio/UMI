namespace OpenNETCF.Tapi
{
    using System;

    public class LINECALLINFO : TapiStruct
    {
        public LINEDIALPARAMS DialParams;
        public int dwAddressID;
        public int dwAddressType;
        public int dwAppNameOffset;
        public int dwAppNameSize;
        public int dwAppSpecific;
        public LINEBEARERMODE dwBearerMode;
        public int dwCallDataOffset;
        public int dwCallDataSize;
        public int dwCalledIDFlags;
        public int dwCalledIDNameOffset;
        public int dwCalledIDNameSize;
        public int dwCalledIDOffset;
        public int dwCalledIDSize;
        public int dwCalledPartyOffset;
        public int dwCalledPartySize;
        public int dwCallerIDFlags;
        public int dwCallerIDNameOffset;
        public int dwCallerIDNameSize;
        public int dwCallerIDOffset;
        public int dwCallerIDSize;
        public int dwCallID;
        public LINECALLPARAMFLAGS dwCallParamFlags;
        public LINECALLSTATE dwCallStates;
        public int dwCallTreatment;
        public int dwChargingInfoOffset;
        public int dwChargingInfoSize;
        public int dwCommentOffset;
        public int dwCommentSize;
        public int dwCompletionID;
        public int dwConnectedIDFlags;
        public int dwConnectedIDNameOffset;
        public int dwConnectedIDNameSize;
        public int dwConnectedIDOffset;
        public int dwConnectedIDSize;
        public int dwCountryCode;
        public int dwDevSpecificOffset;
        public int dwDevSpecificSize;
        public int dwDisplayableAddressOffset;
        public int dwDisplayableAddressSize;
        public int dwDisplayOffset;
        public int dwDisplaySize;
        public int dwHighLevelCompOffset;
        public int dwHighLevelCompSize;
        public int dwLineDeviceID;
        public int dwLowLevelCompOffset;
        public int dwLowLevelCompSize;
        public LINEMEDIAMODE dwMediaMode;
        public LINEDIGITMODE dwMonitorDigitModes;
        public LINEMEDIAMODE dwMonitorMediaModes;
        public int dwNeededSize;
        public int dwNumMonitors;
        public int dwNumOwners;
        public LINECALLORIGIN dwOrigin;
        public int dwRate;
        public LINECALLREASON dwReason;
        public int dwReceivingFlowspecOffset;
        public int dwReceivingFlowspecSize;
        public int dwRedirectingIDFlags;
        public int dwRedirectingIDNameOffset;
        public int dwRedirectingIDNameSize;
        public int dwRedirectingIDOffset;
        public int dwRedirectingIDSize;
        public int dwRedirectionIDFlags;
        public int dwRedirectionIDNameOffset;
        public int dwRedirectionIDNameSize;
        public int dwRedirectionIDOffset;
        public int dwRedirectionIDSize;
        public int dwRelatedCallID;
        public int dwSendingFlowspecOffset;
        public int dwSendingFlowspecSize;
        public int dwTerminalModesOffset;
        public int dwTerminalModesSize;
        public int dwTotalSize;
        public int dwTrunk;
        public int dwUsedSize;
        public int dwUserUserInfoOffset;
        public int dwUserUserInfoSize;
        public IntPtr hLine;

        public LINECALLINFO(int nSize) : base(nSize)
        {
            this.dwTotalSize = nSize;
        }
    }
}

