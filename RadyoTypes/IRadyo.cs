using RadyoTypes;
using System.Collections.Generic;
using System.ServiceModel;

namespace RadyoTypes
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
        List<Record> GetRecordByColumns(Record record);

        [OperationContract]
        List<Casette> GetAllCasette();

        [OperationContract]
        Casette GetCasetteById(int id);
    }
}
