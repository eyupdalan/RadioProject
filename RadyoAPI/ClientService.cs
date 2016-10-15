using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace RadyoAPI
{
    public class ClientService<T> : ClientBase<T> where T : class
    {
        private bool _disposed = false;
        public ClientService()
        {
        }

        public T Proxy
        {
            get { return this.Channel; }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    if (this.State == CommunicationState.Faulted)
                    {
                        base.Abort();
                    }
                    else
                    {
                        try
                        {
                            base.Close();
                        }
                        catch
                        {
                            base.Abort();
                        }
                        _disposed = true;
                    }
                }
            }
        }

    }
}