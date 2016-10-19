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
            Db = new Database("con2");
        }
        public bool IsServiceAwake()
        {
            return true;
        }

        public List<Record> GetAllRecord()
        {
            return Db.Query<Record>("EXEC spGetAllRecord").ToList();
        }

        public Record GetRecordById(int id)
        {
            return Db.SingleOrDefault<Record>("EXEC spGetRecordById " + id);
        }

        public List<Record> GetRecordByColumns(Record record)
        {
            
            return Db.Query<Record>("; EXEC Radyo.dbo.spGetRecordByColumns ", ServiceHelper.ObjectToSqlParameter(record).ToArray()).ToList();
        }

        public List<Casette> GetAllCasette()
        {
            return Db.Query<Casette>("EXEC spGetAllCasette").ToList();
        }

        public Casette GetCasetteById(int id)
        {
            return Db.SingleOrDefault<Casette>("EXEC spGetCasetteById " + id);
        }
    }
}
