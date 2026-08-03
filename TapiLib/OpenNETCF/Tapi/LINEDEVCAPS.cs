namespace OpenNETCF.Tapi
{
    using System;
    using System.Text;

    public class LINEDEVCAPS : TapiStruct
    {
        public LINEDIALPARAMS DefaultDialParams;
        public LINEADDRESSMODE dwAddressModes;
        public LINEANSWERMODE dwAnswerMode;
        public LINEBEARERMODE dwBearerModes;
        public LINEDEVCAPFLAGS dwDevCapFlags;
        public int dwDeviceClassesOffset;
        public int dwDeviceClassesSize;
        public int dwDevSpecificOffset;
        public int dwDevSpecificSize;
        public int dwGatherDigitsMaxTimeout;
        public int dwGatherDigitsMinTimeout;
        public int dwGenerateDigitModes;
        public int dwGenerateToneMaxNumFreq;
        public int dwGenerateToneModes;
        public int dwLineFeatures;
        public int dwLineNameOffset;
        public int dwLineNameSize;
        public LINEDEVSTATE dwLineStates;
        public int dwMaxNumActiveCalls;
        public int dwMaxRate;
        public int dwMedCtlCallStateMaxListSize;
        public int dwMedCtlDigitMaxListSize;
        public int dwMedCtlMediaMaxListSize;
        public int dwMedCtlToneMaxListSize;
        public LINEMEDIAMODE dwMediaModes;
        public int dwMonitorDigitModes;
        public int dwMonitorToneMaxNumEntries;
        public int dwMonitorToneMaxNumFreq;
        public int dwNeededSize;
        public int dwNumAddresses;
        public int dwNumTerminals;
        public int dwPermanentLineID;
        public int dwProviderInfoOffset;
        public int dwProviderInfoSize;
        public int dwRingModes;
        public int dwSettableDevStatus;
        public int dwStringFormat;
        public int dwSwitchInfoOffset;
        public int dwSwitchInfoSize;
        public int dwTerminalCapsOffset;
        public int dwTerminalCapsSize;
        public int dwTerminalTextEntrySize;
        public int dwTerminalTextOffset;
        public int dwTerminalTextSize;
        public int dwTotalSize;
        public int dwUsedSize;
        public int dwUUIAcceptSize;
        public int dwUUIAnswerSize;
        public int dwUUICallInfoSize;
        public int dwUUIDropSize;
        public int dwUUIMakeCallSize;
        public int dwUUISendUserUserInfoSize;
        public LINEDIALPARAMS MaxDialParams;
        public LINEDIALPARAMS MinDialParams;

        public LINEDEVCAPS(int nSize) : base(nSize)
        {
            this.dwTotalSize = nSize;
        }

        public string[] DeviceClasses
        {
            get
            {
                return Encoding.Unicode.GetString(base.Data, this.dwDeviceClassesOffset, this.dwDeviceClassesSize - 1).Split(new char[1]);
            }
        }

        public string LineName
        {
            get
            {
                return ((this.dwLineNameSize == 0) ? "" : Encoding.Unicode.GetString(base.Data, this.dwLineNameOffset, this.dwLineNameSize - 1));
            }
        }

        public string ProviderName
        {
            get
            {
                return ((this.dwProviderInfoSize == 0) ? "" : Encoding.Unicode.GetString(base.Data, this.dwProviderInfoOffset, this.dwProviderInfoSize - 1));
            }
        }
    }
}

