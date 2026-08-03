namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    public class NativeTapi
    {
        [DllImport("coredll")]
        public static extern int lineClose(IntPtr hLine);
        [DllImport("coredll")]
        public static extern int lineDeallocateCall(IntPtr hCall);
        [DllImport("coredll")]
        public static extern int lineDrop(IntPtr hCall, string lpsUserUserInfo, int dwSize);
        [DllImport("coredll")]
        public static extern int lineGetAddressCaps(IntPtr hLineApp, int dwDeviceID, int dwAddressID, int dwAPIVersion, int dwExtVersion, byte[] lpAddressCaps);
        [DllImport("coredll")]
        public static extern int lineGetAddressID(IntPtr hLine, out int lpdwAddressID, LINEADDRESSMODE dwAddressMode, string lpsAddress, int dwSize);
        [DllImport("coredll")]
        public static extern int lineGetAddressStatus(IntPtr hLine, int dwAddressID, byte[] lpAddressStatus);
        [DllImport("coredll")]
        public static extern int lineGetCallInfo(IntPtr hCall, byte[] lpCallInfo);
        [DllImport("coredll")]
        public static extern int lineGetCallStatus(IntPtr hCall, byte[] lpCallStatus);
        [DllImport("coredll")]
        public static extern int lineGetDevCaps(IntPtr m_hLineApp, int dwDeviceID, int dwAPIVersion, int dwExtVersion, byte[] lpLineDevCaps);
        [DllImport("coredll")]
        public static extern int lineGetDevConfig(int dwDeviceID, byte[] lpDeviceConfig, string lpszDeviceClass);
        [DllImport("cellcore")]
        public static extern int lineGetEquipmentState(IntPtr hLine, out LINEEQUIPSTATE lpdwState, out LINERADIOSUPPORT lpdwRadioSupport);
        [DllImport("coredll")]
        public static extern int lineGetID(IntPtr hLine, int dwAddressID, IntPtr hCall, LINECALLSELECT dwSelect, byte[] lpDeviceID, string lpszDeviceClass);
        [DllImport("coredll")]
        public static extern int lineGetLineDevStatus(IntPtr hLine, byte[] lpLineDevStatus);
        [DllImport("coredll")]
        public static extern int lineGetMessage(IntPtr m_hLineApp, out LINEMESSAGE lpMessage, int dwTimeout);
        [DllImport("coredll")]
        public static extern int lineGetNewCalls(IntPtr hLine, int dwAddressID, LINECALLSELECT dwSelect, byte[] lpCallList);
        [DllImport("coredll")]
        public static extern int lineHold(IntPtr hCall);
        [DllImport("coredll")]
        public static extern int lineInitializeEx(out IntPtr lpm_hLineApp, IntPtr hInstance, IntPtr lpfnCallback, string lpszFriendlyAppName, out int lpdwNumDevs, ref int lpdwAPIVersion, LINEINITIALIZEEXPARAMS lpLineInitializeExParams);
        [DllImport("coredll")]
        public static extern int lineMakeCall(IntPtr hLine, out IntPtr lphCall, string lpszDestAddress, int dwCountryCode, byte[] lpCallParams);
        [DllImport("coredll")]
        public static extern int lineMonitorDigits(IntPtr hCall, LINEDIGITMODE dwDigitModes);
        [DllImport("coredll")]
        public static extern int lineNegotiateAPIVersion(IntPtr m_hLineApp, int dwDeviceID, int dwAPILowVersion, int dwAPIHighVersion, out int lpdwAPIVersion, out LINEEXTENSIONID lpExtensionID);
        [DllImport("coredll")]
        public static extern int lineOpen(IntPtr m_hLineApp, int dwDeviceID, out IntPtr lphLine, int dwAPIVersion, int dwExtVersion, IntPtr dwCallbackInstance, LINECALLPRIVILEGE dwPrivileges, LINEMEDIAMODE dwMediaModes, LINECALLPARAMS lpCallParams);
        [DllImport("coredll")]
        public static extern int lineOpen(IntPtr m_hLineApp, int dwDeviceID, out IntPtr lphLine, int dwAPIVersion, int dwExtVersion, IntPtr dwCallbackInstance, LINECALLPRIVILEGE dwPrivileges, LINEMEDIAMODE dwMediaModes, IntPtr lpCallParams);
        [DllImport("cellcore")]
        public static extern int lineSetEquipmentState(IntPtr hLine, LINEEQUIPSTATE dwState);
        [DllImport("coredll")]
        public static extern int lineSetGPRSClass(IntPtr hLine, LINEGPRSCLASS dwClass);
        [DllImport("coredll")]
        public static extern int lineSetStatusMessages(IntPtr hLine, LINEDEVSTATE dwLineStates, LINEADDRESSSTATE dwAddressStates);
        [DllImport("coredll")]
        public static extern int lineShutdown(IntPtr m_hLineApp);
    }
}

