namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    public class CellTSP
    {
        public const string CELLTSP_LINENAME_STRING = "Cellular Line";
        public const string CELLTSP_PHONENAME_STRING = "Cellular Phone";
        public const string CELLTSP_PROVIDERINFO_STRING = "Cellular TAPI Service Provider";
        public const int MAX_LENGTH_OPERATOR_LONG = 0x20;
        public const int MAX_LENGTH_OPERATOR_NUMERIC = 0x10;
        public const int MAX_LENGTH_OPERATOR_SHORT = 0x10;

        [DllImport("cellcore")]
        public static extern int lineGetCallBarringCaps(IntPtr hLine, out LINEBARRMODE lpdwModes, out int lpdwClasses);
        [DllImport("cellcore")]
        public static extern int lineGetCallBarringState(IntPtr hLine, LINEBARRMODE dwMode, out int lpdwClasses, string lpszPassword);
        [DllImport("cellcore")]
        public static extern int lineGetCallWaitingCaps(IntPtr hLine, out int lpdwClasses);
        [DllImport("cellcore")]
        public static extern int lineGetCallWaitingState(IntPtr hLine, out int lpdwClasses);
        [DllImport("cellcore")]
        public static extern int lineGetCurrentAddressID(IntPtr hLine, out int lpdwAddressID);
        [DllImport("cellcore")]
        public static extern int lineGetCurrentHSCSDStatus(IntPtr hLine, out int lpdwChannelsIn, out int lpdwChannelsOut, out int lpdwChannelCoding, out int lpdwAirInterfaceRate);
        [DllImport("cellcore")]
        public static extern int lineGetCurrentOperator(IntPtr hLine, byte[] lpCurrentOperator);
        [DllImport("cellcore")]
        public static extern int lineGetCurrentSystemType(IntPtr hLine, out LINESYSTEMTYPE lpdwCurrentSystemType);
        [DllImport("cellcore")]
        public static extern int lineGetEquipmentState(IntPtr hLine, out int lpdwState, out LINERADIOSUPPORT lpdwRadioSupport);
        [DllImport("cellcore")]
        public static extern int lineGetGeneralInfo(IntPtr hLine, byte[] lpLineGeneralInfo);
        [DllImport("cellcore")]
        public static extern int lineGetGPRSClass(IntPtr hLine, out int lpdwClass);
        [DllImport("cellcore")]
        public static extern int lineGetHSCSDCaps(IntPtr hLine, out int lpdwClass, out int lpdwChannelsIn, out int lpdwChannelsOut, out int lpdwChannelsSum, out int lpdwChannelCodings);
        [DllImport("cellcore")]
        public static extern int lineGetHSCSDState(IntPtr hLine, out int lpdwChannelsIn, out int lpdwMaxChannelsIn, out int lpdwChannelCodings, out int lpdwAirInterfaceRate);
        [DllImport("cellcore")]
        public static extern int lineGetMuteState(IntPtr hLine, out int lpdwState);
        [DllImport("cellcore")]
        public static extern int lineGetNumberCalls(IntPtr hLine, out int lpdwNumActiveCalls, out int lpdwNumOnHoldCalls, out int lpdwNumOnHoldPendCalls);
        [DllImport("cellcore")]
        public static extern int lineGetOperatorStatus(IntPtr hLine, byte[] lpOperatorStatus);
        [DllImport("cellcore")]
        public static extern int lineGetRadioPresence(IntPtr hLine, out LINERADIOPRESENCE lpdwRadioPresence);
        [DllImport("cellcore")]
        public static extern int lineGetRegisterStatus(IntPtr hLine, out LINEREGSTATUS lpdwRegisterStatus);
        [DllImport("cellcore")]
        public static extern int lineGetSendCallerIDState(IntPtr hLine, out int lpdwState);
        [DllImport("cellcore")]
        public static extern int lineGetUSSD(IntPtr hLine, int dwID, byte[] lpbUSSD, int dwUSSDSize, out int lpdwFlags);
        [DllImport("cellcore")]
        public static extern int lineRegister(IntPtr hLine, int dwRegisterMode, string lpszOperator, int dwOperatorFormat);
        [DllImport("cellcore")]
        public static extern int lineSetCallBarringPassword(IntPtr hLine, int dwMode, string lpszOldPassword, string lpszNewPassword);
        [DllImport("cellcore")]
        public static extern int lineSetCallBarringState(IntPtr hLine, int dwMode, int dwClasses, string lpszPassword);
        [DllImport("cellcore")]
        public static extern int lineSetCallWaitingState(IntPtr hLine, int dwClasses, int dwState);
        [DllImport("cellcore")]
        public static extern int lineSetCurrentAddressID(IntPtr hLine, int dwAddressID);
        [DllImport("cellcore")]
        public static extern int lineSetEquipmentState(IntPtr hLine, int dwState);
        [DllImport("cellcore")]
        public static extern int lineSetGPRSClass(IntPtr hLine, int dwClass);
        [DllImport("cellcore")]
        public static extern int lineSetHSCSDState(IntPtr hLine, int dwChannelsIn, int dwMaxChannelsIn, int dwChannelCodings, int dwAirInterfaceRate);
        [DllImport("cellcore")]
        public static extern int lineSetMuteState(IntPtr hLine, int dwState);
        [DllImport("cellcore")]
        public static extern int lineSetPreferredOperator(IntPtr hLine, byte[] lpOperator);
        [DllImport("cellcore")]
        public static extern int lineSetSendCallerIDState(IntPtr hLine, int dwState);
        [DllImport("cellcore")]
        public static extern int lineUnregister(IntPtr hLine);
    }
}

