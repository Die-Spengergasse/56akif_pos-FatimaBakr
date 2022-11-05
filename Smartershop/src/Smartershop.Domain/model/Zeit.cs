using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartershop.Domain.model
{
    public class Zeit
    {
        public int ZeitId { get; set; }
        public int Zeitvon { get; set; }
        public int Zeitbis { get; set; }
        public List<Preis> Preise { get; set; }
    }
}
