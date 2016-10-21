using PetaPoco;
using RadyoCommon;
using RadyoTypes;
using System.Collections.Generic;

namespace RadyoServis
{
    public class Radyo : ServiceBase, IRadyo
    {
        private Database Db;

        public Radyo()
        {
            Db = new Database("con2"); // Default : con1
        }

        public bool IsServiceAwake()
        {
            return true;
        }

        public List<Record> GetAllRecord()
        {
            List<Record> list = new List<Record>();
            RunInTryCatch(() =>
            {
                list = Db.Fetch<Record>("; EXEC Radyo.dbo.spGetAllRecord");
            });

            return list;
        }

        public Record GetRecordById(int id)
        {
            Record record = new Record();
            RunInTryCatch(() =>
            {
                record = Db.SingleOrDefault<Record>("; EXEC Radyo.dbo.spGetRecordByIds " + id);
            });
            return record;
        }

        public List<Record> GetRecordByColumns(Record record)
        {
            List<Record> list = new List<Record>();
            RunInTryCatch(() =>
            {
                list = Db.Fetch<Record>("; EXEC Radyo.dbo.spGetRecordByColumns " + ServiceHelper.CountParams(record),
                                    ServiceHelper.ObjectToSqlParameter(record).ToArray());
            });

            return list;
        }

        public List<Casette> GetAllCasette()
        {
            List<Casette> list = new List<Casette>();
            RunInTryCatch(() =>
            {
                list = Db.Fetch<Casette>("; EXEC Radyo.dbo.spGetAllCasette");
            });
            return list;
        }

        public Casette GetCasetteById(int id)
        {
            Casette casette = new Casette();
            RunInTryCatch(() =>
            {
                casette = Db.SingleOrDefault<Casette>("; EXEC Radyo.dbo.spGetCasetteById " + id);
            });
            return casette;
        }

        public List<Casette> GetCasetteByColumns(Casette casette)
        {
            List<Casette> list = new List<Casette>();
            RunInTryCatch(() =>
            {
                Db.Fetch<Casette>("; EXEC Radyo.dbo.spGetCasetteByColumns " + ServiceHelper.CountParams(casette),
                                    ServiceHelper.ObjectToSqlParameter(casette).ToArray());
            });
            return list;
        }
    }
}
