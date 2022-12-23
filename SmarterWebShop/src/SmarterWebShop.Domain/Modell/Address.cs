using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Domain.Modell
{
    public class Address
    {
        public string City { get; set; } = String.Empty;
        public string Street { get; set; }= String.Empty;
        public string Number { get; set; }=String.Empty;
        public string Zip { get; set; } = String.Empty;
        
    }
}
