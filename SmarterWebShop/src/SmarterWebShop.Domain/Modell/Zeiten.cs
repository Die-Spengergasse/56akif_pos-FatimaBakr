using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Domain.Modell
{
    public class Zeiten
    {
        public Zeiten(int Id, int zeitvon, int zeitbis)
        {
            Id = Id;
            Zeitvon = zeitvon;
            Zeitbis = zeitbis;
        }
        protected Zeiten()
        {

        }

        public int Id { get; private set;  }
        public int Zeitvon { get; set; }
        public int Zeitbis { get; set; }
        public List<Preise> Preisen { get; set; } = new();
    }
}
