namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    public class LINEINITIALIZEEXPARAMS
    {
        public int dwCompletionKey;
        public int dwNeededSize;
        public int dwOptions;
        public int dwTotalSize;
        public int dwUsedSize;
        public IntPtr hEvent;
        private const int LINEINITIALIZEEXOPTION_USEEVENT = 2;

        public LINEINITIALIZEEXPARAMS(IntPtr hEvent)
        {
            this.hEvent = hEvent;
            this.dwTotalSize = Marshal.SizeOf(typeof(LINEINITIALIZEEXPARAMS));
            this.dwOptions = 2;
        }
    }
}

