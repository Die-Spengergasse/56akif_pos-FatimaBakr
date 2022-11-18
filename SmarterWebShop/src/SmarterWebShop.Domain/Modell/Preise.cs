using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Domain.Modell
{
    public class Preise
    {
        public int PreisId { get; set; }
        public long Preiswert { get; set; }
        public List<Rechnung> Rechnungen { get; set; } = new();
        public Zeiten ZeitNavigation { get; set; } = new();
        public Produkte ProduktNavigation { get; set; } = new();
    }
}
