using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Street
    /// * Zip
    /// * City
    /// (2P)
    /// </summary>
    public class Address
    {
        protected Address()
        {

        }

        public Address(string street, string zip, string city, string countryCode)
        {
            Street = street;
            Zip = zip;
            City = city;
            CountryCode = countryCode;
        }

        // TOD
        public string Street { get; set; }          // NULL
        public string Zip { get; set; }             // NULL
        public string City { get; set; }            // NULL
        public string CountryCode { get; set; }     // NULL
        
    }
    
}
