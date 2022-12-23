using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Domain.Modell
{
    public class Produkte
    {
        public Produkte(long id, string name)
        {
            Id = id;
            Name = name;
            
          
        }
        protected Produkte()
        {

        }

        public long Id { get; private set; }
        public string Name { get; set; } = string.Empty;
        
        public List<Kunden> Kunden { get; set; } = new();
        public List<Preise> Preise { get; set; } = new();
        public List<Rechnung> Rechnungen { get; set; } = new();
    }
}
