using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmarterWebShop.Domain.Modell
{
    public class Kunden
    {
        public Kunden(long id, string vorname, string nachname, string email, Address address, string? phoneNumber, DateTime registrationDateTime)
        {
            Id = id;
            Vorname = vorname;
            Nachname = nachname;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            RegistrationDateTime = registrationDateTime;
        }
        protected Kunden()
        {

        }

        public long Id { get; private set; }
        public string Vorname { get; set; } = String.Empty;
        public string Nachname { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public Address? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime RegistrationDateTime { get; private set; }
        private List<Produkte> Produktes = new();
        public IReadOnlyList<Produkte> _Produktes => Produktes;
        private List<Rechnung> Rechnungen { get; set; } = new();
    }
}
