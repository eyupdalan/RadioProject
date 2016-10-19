using RadyoTypes;
using System.Collections.Generic;
using System.Web.Http;

namespace RadyoAPI.Controllers
{
    public class RecordController : ApiController
    {
        ClientService<IRadyo> service = new ClientService<IRadyo>();

        public List<Record> Get()
        {
            Record record = new Record { BookId = 4, TopicId = 5 };
            return service.Proxy.GetRecordByColumns(record);
        }
    }
}
