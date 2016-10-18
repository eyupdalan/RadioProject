using RadyoTypes;
using System.Collections.Generic;
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
