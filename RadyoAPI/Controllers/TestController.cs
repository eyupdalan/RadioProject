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
            return new
            {
                IsServiceUp = service.Proxy.IsServiceAwake()
            };

        }
    }
}
