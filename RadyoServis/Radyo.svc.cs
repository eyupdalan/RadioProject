using PetaPoco;
using RadyoTypes;
using System.Collections.Generic;

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
            return Db.Fetch<Record>("; EXEC Radyo.dbo.spGetAllRecord");
        }

        public Record GetRecordById(int id)
        {
            return Db.SingleOrDefault<Record>("; EXEC Radyo.dbo.spGetRecordById " + id);
        }

        public List<Record> GetRecordByColumns(Record record)
        {

            return Db.Fetch<Record>("; EXEC Radyo.dbo.spGetRecordByColumns " + ServiceHelper.CountParams(record), 
                                    ServiceHelper.ObjectToSqlParameter(record).ToArray());
        }

        public List<Casette> GetAllCasette()
        {
            return Db.Fetch<Casette>("; EXEC Radyo.dbo.spGetAllCasette");
        }

        public Casette GetCasetteById(int id)
        {
            return Db.SingleOrDefault<Casette>("; EXEC Radyo.dbo.spGetCasetteById " + id);
        }

        public List<Casette> GetCasetteByColumns(Casette casette)
        {

            return Db.Fetch<Casette>("; EXEC Radyo.dbo.spGetCasetteByColumns " + ServiceHelper.CountParams(casette),
                                    ServiceHelper.ObjectToSqlParameter(casette).ToArray());
        }
    }
}
