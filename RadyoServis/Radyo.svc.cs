using PetaPoco;
using RadyoTypes;
using System.Collections.Generic;
using System.Linq;

namespace RadyoServis
{
    public class Radyo : IRadyo
    {
        private Database Db;

        public Radyo()
        {
            Db = new Database("con");
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
