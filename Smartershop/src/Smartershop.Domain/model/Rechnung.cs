using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartershop.Domain.model
{
    public class Rechnung
    {
        public int RechnungID { get; set; }
        public string Datum { get; set; } = string.Empty;
        public int GewichInGramm { get; set; }

    }
}
