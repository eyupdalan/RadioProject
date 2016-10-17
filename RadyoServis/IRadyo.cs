using RadyoTypes;
using System.Collections.Generic;
using System.ServiceModel;

namespace RadyoServis
{
    [ServiceContract]
    public interface IRadyo
    {
        [OperationContract]
        bool IsServiceAwake();

        [OperationContract]
        List<Record> GetAllRecord();

        [OperationContract]
        Record GetRecordById(int id);

        [OperationContract]
        List<Casette> GetAllCasette();

        [OperationContract]
        Casette GetCasetteById(int id);
    }
}
