using RadyoServis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RadyoAPI.Controllers
{
    public class TestController : ApiController
    {
        public object Get()
        {
            ClientService<IRadyo> service = new ClientService<IRadyo>();
            string ret = service.Proxy.IsServiceAwake();

            int[] arr = new int[] { 1, 2, 4 };
            return new
            {
                arr = arr,
                data = ret
            };

        }
    }
}
