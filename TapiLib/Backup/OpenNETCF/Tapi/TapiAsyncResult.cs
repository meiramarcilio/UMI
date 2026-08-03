namespace OpenNETCF.Tapi
{
    using System;
    using System.Threading;

    internal class TapiAsyncResult : IAsyncResult
    {
        private AsyncCallback m_callback;
        private ManualResetEvent m_eventDone;
        protected int m_replyID;
        private object m_state;

        internal TapiAsyncResult(int ReplyID, AsyncCallback callback, object State)
        {
            this.m_replyID = ReplyID;
            this.m_callback = callback;
            this.m_state = State;
        }

        public object AsyncState
        {
            get
            {
                return this.m_state;
            }
        }

        public WaitHandle AsyncWaitHandle
        {
            get
            {
                if (this.m_eventDone == null)
                {
                    this.m_eventDone = new ManualResetEvent(false);
                }
                return this.m_eventDone;
            }
        }

        internal AsyncCallback Callback
        {
            get
            {
                return this.m_callback;
            }
        }

        public bool CompletedSynchronously
        {
            get
            {
                return (this.m_replyID < 0);
            }
        }

        public virtual bool IsCompleted
        {
            get
            {
                return false;
            }
        }

        internal int ReplyID
        {
            get
            {
                return this.m_replyID;
            }
            set
            {
                this.m_replyID = value;
            }
        }
    }
}

