using RadyoCommon;
using RadyoTypes;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Web.Http;

namespace RadyoAPI.Controllers
{
    public class RecordController : ApiController
    {
        ClientService<IRadyo> service = new ClientService<IRadyo>();

        /// <summary>
        /// Get all records
        /// </summary>
        /// <returns></returns>
        public List<Record> GetAll()
        {
            return service.Proxy.GetAllRecord();
        }

        /// <summary>
        /// Get records which supplies the criteria inside record object.
        /// HTTP GET doesn't allow request body for a json object
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        [HttpPost]
        public List<Record> GetByColumn(Record record)
        {
            return service.Proxy.GetRecordByColumns(record);
        }

        /// <summary>
        /// Get records by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetById(int id)
        {
            Record record = new Record();
            try { record = service.Proxy.GetRecordById(id); }
            catch(FaultException ex)
            {
                return InternalServerError(ex);
            }

            return Ok(record);
        }


    }
}
