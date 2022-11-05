using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartershop.Domain.model
{
    public class Kunde
    {
        public int Id { get; set; } = 0;
        public string Vorname { get; set; } = String.Empty;
        public string Nachname { get; set; } = String.Empty;  
        public string Email { get; set; } = String.Empty;
        public List<Produkt> Produkte { get; set; } = new();
        public List<Rechnung> Rechnungen { get; set; } = new();
    }
}
