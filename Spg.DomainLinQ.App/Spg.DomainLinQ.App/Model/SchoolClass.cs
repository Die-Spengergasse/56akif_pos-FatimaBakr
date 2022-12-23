using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Name
    /// * Department [Die ersten 3 Zeichen von Name]
    /// * Guid
    /// (4P)
    /// </summary>
    public class SchoolClass : EntityBase
    {



        protected SchoolClass()
        {

        }

        // TODO: Implementation
        public Teacher? Kv { get; set; } 
        public string Name { get; set; } = String.Empty;
        public string Department => Name.Substring(0, 2);
        public int? Guid { get; set; }
    }
}
