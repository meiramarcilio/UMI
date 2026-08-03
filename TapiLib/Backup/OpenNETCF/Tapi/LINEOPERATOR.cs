namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;

    public class LINEOPERATOR
    {
        public int dwIndex;
        public int dwStatus;
        public int dwValidFields;
        [Array(0x40)]
        public byte[] lpszLongName = new byte[0x40];
        [Array(0x20)]
        public byte[] lpszNumName = new byte[0x20];
        [Array(0x20)]
        public byte[] lpszShortName = new byte[0x20];

        public string LongName
        {
            get
            {
                return Encoding.Unicode.GetString(this.lpszLongName, 0, this.lpszLongName.Length).TrimEnd(new char[1]);
            }
        }

        public string NumName
        {
            get
            {
                return Encoding.Unicode.GetString(this.lpszNumName, 0, this.lpszNumName.Length).TrimEnd(new char[1]);
            }
        }

        public string ShortName
        {
            get
            {
                return Encoding.Unicode.GetString(this.lpszShortName, 0, this.lpszShortName.Length).TrimEnd(new char[1]);
            }
        }

        public int SizeOf
        {
            get
            {
                return ((3 * Marshal.SizeOf(typeof(int))) + 0x80);
            }
        }
    }
}

