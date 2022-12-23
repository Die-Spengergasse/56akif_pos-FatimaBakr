using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * RegistrationNumber
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * PhoneNumber
    /// * AccountName = [Die ersten 5 Stellen des LastName + RegistrationNumber]
    /// * Gender
    /// * Guid
    /// (4P)s
    /// </summary>
    public class Student : EntityBase
    {
        protected Student()
        {

        }

        public Student(int registrationNumber, string firstName, string lastName, string eMail, Address? address, int? phoneNumber, Enums? gender, int guid, List<Subject> subjects, List<SchoolClass> schoolClasses, Enums? genders)
        {
            RegistrationNumber = registrationNumber;
            FirstName = firstName;
            LastName = lastName;
            EMail = eMail;
            Address = address;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Guid = guid;
            _subjects = subjects;
            this.schoolClasses = schoolClasses;
            Genders = genders;
        }


        // TODO: Implementation
        public int RegistrationNumber { get; private set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public Address? Address { get; set; } = default!;
        public int? PhoneNumber { get; set; }
        public string AccountName => LastName.Substring(0, 4)+ RegistrationNumber;
        public Enums? Gender { get; set; }
        public int? Guid { get; set; }




        private List<Subject> _subjects = new();

        public void AddSubjects(List<Subject> subjects)
        {
            _subjects.AddRange(subjects);
        }
        List<SchoolClass> schoolClasses { get; set; } = new();
        public Enum? Genders { get; set; }
    }
}
