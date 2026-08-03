namespace OpenNETCF.Tapi
{
    using System;
    using System.Runtime.InteropServices;

    internal class MakeCallAsyncResult : TapiAsyncResult, IDisposable
    {
        private GCHandle m_handle;
        internal IntPtr m_hCall;

        internal MakeCallAsyncResult(int ReplyID, AsyncCallback callback, object State) : base(ReplyID, callback, State)
        {
            this.m_handle = GCHandle.Alloc(this, GCHandleType.Pinned);
        }

        public void Dispose()
        {
            this.m_handle.Free();
        }

        internal IntPtr hCall
        {
            get
            {
                return this.m_hCall;
            }
        }

        public override bool IsCompleted
        {
            get
            {
                return ((this.m_hCall != IntPtr.Zero) || (base.ReplyID <= 0));
            }
        }
    }
}

