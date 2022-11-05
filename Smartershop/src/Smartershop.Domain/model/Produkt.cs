using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartershop.Domain.model
{
    public class Produkt
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public List<Kunde> Kunden { get; set; } = new(); 
        public List<Preis> Preise { get; set; } = new();
        public List<Rechnung> Rechnungen { get; set; } = new();
    }
}
