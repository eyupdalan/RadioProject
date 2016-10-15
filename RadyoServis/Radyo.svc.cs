using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RadyoServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Radyo" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Radyo.svc or Radyo.svc.cs at the Solution Explorer and start debugging.
    public class Radyo : IRadyo
    {

        public string IsServiceAwake()
        {
            return "Ayaktayım";
        }
    }
}
