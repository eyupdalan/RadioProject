using RadyoTypes;
using System.Collections.Generic;
using System.Web.Http;

namespace RadyoAPI.Controllers
{
    public class CasetteController : ApiController
    {
        ClientService<RadyoServis.IRadyo> service = new ClientService<RadyoServis.IRadyo>();

        public List<Record> Get()
        {
            Record record = new Record { BookId = 4, TopicId = 5 };
            return service.Proxy.GetRecordByColumns(record);
        }
    }
}
