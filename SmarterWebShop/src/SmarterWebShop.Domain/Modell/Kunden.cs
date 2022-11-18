using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Domain.Modell
{
    public class Kunden
    {
        public int Id { get; set; } = 0;
        public string Vorname { get; set; } = String.Empty;
        public string Nachname { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public Produkte ProdukteNavigation { get; set; } = new();
        public List<Produkte> Produkte { get; set; } = new();
        public List<Rechnung> Rechnungen { get; set; } = new();
    }
}
