namespace OpenNETCF.Tapi
{
    using System;
    using System.Text;

    public class LINEGENERALINFO : TapiStruct
    {
        public int dwManufacturerOffset;
        public int dwManufacturerSize;
        public int dwModelOffset;
        public int dwModelSize;
        public int dwNeededSize;
        public int dwRevisionOffset;
        public int dwRevisionSize;
        public int dwSerialNumberOffset;
        public int dwSerialNumberSize;
        public int dwSubscriberNumberOffset;
        public int dwSubscriberNumberSize;
        public int dwTotalSize;
        public int dwUsedSize;

        public LINEGENERALINFO(int size) : base(size)
        {
            this.dwTotalSize = size;
        }

        public string Manufacturer
        {
            get
            {
                return ((this.dwManufacturerSize == 0) ? "" : Encoding.Unicode.GetString(base.Data, this.dwManufacturerOffset, this.dwManufacturerSize));
            }
        }

        public string Model
        {
            get
            {
                return ((this.dwModelSize == 0) ? "" : Encoding.Unicode.GetString(base.Data, this.dwModelOffset, this.dwModelSize));
            }
        }

        public string Revision
        {
            get
            {
                return ((this.dwRevisionSize == 0) ? "" : Encoding.Unicode.GetString(base.Data, this.dwRevisionOffset, this.dwRevisionSize));
            }
        }

        public string SerialNumber
        {
            get
            {
                return ((this.dwSerialNumberSize == 0) ? "" : Encoding.Unicode.GetString(base.Data, this.dwSerialNumberOffset, this.dwSerialNumberSize));
            }
        }

        public string SubscriberNumber
        {
            get
            {
                return ((this.dwSubscriberNumberSize == 0) ? "" : Encoding.Unicode.GetString(base.Data, this.dwSubscriberNumberOffset, this.dwSubscriberNumberSize));
            }
        }
    }
}

