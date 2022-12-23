using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * Gender
    /// * Guid
    /// (4P)
    /// </summary>
    public class Teacher : EntityBase
    {
        protected Teacher()
        {

        }

        public Teacher(string firstName, string lastName, string? eMail, Address? address, Enums? gender, int? guid)
        {
            FirstName = firstName;
            LastName = lastName;
            EMail = eMail;
            Address = address;
            Gender = gender;
            Guid = guid;
        }

        // TODO: Implementation
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? EMail { get; set; }
        public Enums? Gender { get; set; }
        public Address? Address { get; set; } = default!;
        
        public int? Guid { get; set; }

        private List<Subject> _subjects = new();

        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }
    }
}
