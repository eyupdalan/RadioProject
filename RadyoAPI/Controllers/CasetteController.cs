using RadyoTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RadyoAPI.Controllers
{
    public class CasetteController : ApiController
    {
        ClientService<RadyoServis.IRadyo> service = new ClientService<RadyoServis.IRadyo>();

        public List<Casette> Get()
        {
            return service.Proxy.GetAllCasette();
        }
    }
}
