namespace OpenNETCF.Tapi
{
    using System;

    [Flags]
    public enum LINEMEDIAMODE
    {
        ADSI = 0x2000,
        AUTOMATEDVOICE = 8,
        DATAMODEM = 0x10,
        DIGITALDATA = 0x100,
        G3FAX = 0x20,
        G4FAX = 0x80,
        INTERACTIVEVOICE = 4,
        LAST_LINEMEDIAMODE = 0x4000,
        MIXED = 0x1000,
        TDD = 0x40,
        TELETEX = 0x200,
        TELEX = 0x800,
        UNKNOWN = 2,
        VIDEOTEX = 0x400,
        VOICEVIEW = 0x4000
    }
}

