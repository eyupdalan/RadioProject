using PetaPoco;
using RadyoTypes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace RadyoServis
{
    public class Radyo : IRadyo
    {
        private Database Db;

        public Radyo()
        {
            Db = new Database("con2"); // Default : con
        }
        public bool IsServiceAwake()
        {
            return true;
        }

        public List<Record> GetAllRecord()
        {
            return Db.Fetch<Record>("; EXEC spGetAllRecord");
        }

        public Record GetRecordById(int id)
        {
            return Db.SingleOrDefault<Record>("; EXEC spGetRecordById " + id);
        }

        public List<Record> GetRecordByColumns(Record record)
        {

            return Db.Fetch<Record>("; EXEC Radyo.dbo.spGetRecordByColumns " + ServiceHelper.CountParams(record), 
                                    ServiceHelper.ObjectToSqlParameter(record).ToArray());
        }

        public List<Casette> GetAllCasette()
        {
            return Db.Fetch<Casette>("; EXEC spGetAllCasette");
        }

        public Casette GetCasetteById(int id)
        {
            return Db.SingleOrDefault<Casette>("; EXEC spGetCasetteById " + id);
        }
    }
}
