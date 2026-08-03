namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEBEARERMODE
    {
        ALTSPEECHDATA = 0x10,
        DATA = 8,
        MULTIUSE = 4,
        NONCALLSIGNALING = 0x20,
        PASSTHROUGH = 0x40,
        SPEECH = 2,
        VOICE = 1
    }
}

