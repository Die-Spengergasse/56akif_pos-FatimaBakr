using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Description
    /// (4P)
    /// </summary>
    public class Subject : EntityBase
    {
        protected Subject()
        {

        }

        public Subject(string description)
        {
            Description = description;
        }

        List<SchoolClass> SchoolClasses { get; set; } = new();
        public string Description { get; set; } = String.Empty;
        List<Teacher>teachers { get; set; } = new();
        // TODO: Implementation
    }
}
