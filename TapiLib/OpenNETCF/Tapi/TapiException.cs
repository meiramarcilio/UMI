namespace OpenNETCF.Tapi
{
    using System;

    public class TapiException : Exception
    {
        private string message;
        public int NativeError;

        public TapiException(int err)
        {
            this.NativeError = err;
        }

        public TapiException(string message, int err)
        {
            this.NativeError = err;
            this.message = message;
        }

        public override string Message
        {
            get
            {
                return string.Format("{0} {1}", this.message, (LINEERR) this.NativeError);
            }
        }
    }
}

