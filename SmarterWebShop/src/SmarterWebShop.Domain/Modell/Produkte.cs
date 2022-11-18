using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Domain.Modell
{
    public class Produkte
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public Kunden KundeNavigation { get; set; } = new();
        public List<Kunden> Kunden { get; set; } = new();
        public List<Preise> Preise { get; set; } = new();
        public List<Rechnung> Rechnungen { get; set; } = new();
    }
}
