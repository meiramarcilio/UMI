namespace OpenNETCF.Tapi
{
    using System;

    public class LINEADDRESSCAPS : TapiStruct
    {
        public int dwAddrCapFlags;
        public int dwAddressFeatures;
        public int dwAddressOffset;
        public int dwAddressSharing;
        public int dwAddressSize;
        public int dwAddressStates;
        public int dwAvailableMediaModes;
        public int dwBusyModes;
        public int dwCallCompletionConds;
        public int dwCallCompletionModes;
        public int dwCalledIDFlags;
        public int dwCallerIDFlags;
        public int dwCallFeatures;
        public int dwCallFeatures2;
        public LINECALLINFOSTATE dwCallInfoStates;
        public LINECALLSTATE dwCallStates;
        public int dwCallTreatmentListOffset;
        public int dwCallTreatmentListSize;
        public int dwCompletionMsgTextEntrySize;
        public int dwCompletionMsgTextOffset;
        public int dwCompletionMsgTextSize;
        public int dwConnectedIDFlags;
        public int dwConnectedModes;
        public int dwDeviceClassesOffset;
        public int dwDeviceClassesSize;
        public int dwDevSpecificOffset;
        public int dwDevSpecificSize;
        public int dwDialToneModes;
        public LINEDISCONNECTMODE dwDisconnectModes;
        public LINEFORWARDMODE dwForwardModes;
        public int dwLineDeviceID;
        public int dwMaxCallCompletions;
        public int dwMaxCallDataSize;
        public int dwMaxForwardEntries;
        public int dwMaxFwdNumRings;
        public int dwMaxNoAnswerTimeout;
        public int dwMaxNumActiveCalls;
        public int dwMaxNumConference;
        public int dwMaxNumOnHoldCalls;
        public int dwMaxNumOnHoldPendingCalls;
        public int dwMaxNumTransConf;
        public int dwMaxSpecificEntries;
        public int dwMinFwdNumRings;
        public int dwNeededSize;
        public int dwNumCallTreatments;
        public int dwNumCompletionMessages;
        public int dwOfferingModes;
        public int dwParkModes;
        public int dwPredictiveAutoTransferStates;
        public int dwRedirectingIDFlags;
        public int dwRedirectionIDFlags;
        public int dwRemoveFromConfCaps;
        public int dwRemoveFromConfState;
        public int dwSpecialInfo;
        public int dwTotalSize;
        public int dwTransferModes;
        public int dwUsedSize;

        public LINEADDRESSCAPS(int size) : base(size)
        {
            this.dwTotalSize = size;
        }
    }
}

