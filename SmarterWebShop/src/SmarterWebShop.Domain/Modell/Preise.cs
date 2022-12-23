using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Domain.Modell
{
    public class Preise
    {
        public Preise(int Id, long preiswert)
        {
            Id = Id;
            Preiswert = preiswert;
            
        }
        protected Preise()
        {

        }

        public int Id { get; private set; }
        public long Preiswert { get; set; }
       
        
        
        public List<Rechnung> Rechnungen { get; set; } = new();
    }
}
