using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Domain.Modell
{
    public class Zeiten
    {
        public int ZeitId { get; set; }
        public int Zeitvon { get; set; }
        public int Zeitbis { get; set; }
        public List<Preise> Preisen { get; set; } = new();
    }
}
