using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Domain.Modell
{
    public class Rechnung
    {
        public int RechnungID { get; set; }
        public DateTime Datum { get; set; }
        public int GewichInGramm { get; set; }
        public Kunden KundeNavigation { get; set; } = new();
        public Produkte ProdukteNavigation { get; set; } = new();
        public Preise PreiseNavigation { get; set; } = new();
    }
}
