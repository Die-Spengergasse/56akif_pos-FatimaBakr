using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartershop.Domain.model
{
    public class Preis
    {
        public int PreisId { get; set; }
        public long Preiswert { get; set; }
        public List<Rechnung> Rechnungen { get; set; } = new();
    }
}
