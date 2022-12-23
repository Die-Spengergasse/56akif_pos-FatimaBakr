using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Domain.Modell
{
    public class Rechnung
    {
        public Rechnung(int ID, DateTime datum, int gewichInGramm)
        {
            ID = ID;
            Datum = datum;
            GewichInGramm = gewichInGramm;
        }
        protected Rechnung()
        {

        }

        public int ID { get; private set;  }
        public DateTime Datum { get; private set;  }
        public int GewichInGramm { get; set; }
        
        
       
    }
}
