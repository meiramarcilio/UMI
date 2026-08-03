namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct CELLGPRSQOSSETTINGS
    {
        public GPRSPRECEDENCECLASS dwPrecedenceClass;
        public GPRSDELAYCLASS dwDelayClass;
        public GPRSRELIABILITYCLASS dwReliabilityClass;
        public PEAKTHRUCLASS dwPeakThruClass;
        public MEANTHRUCLASS dwMeanThruClass;
    }
}

