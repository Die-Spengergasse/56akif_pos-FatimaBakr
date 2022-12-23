using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// Number
    /// (2P)
    /// </summary>
    public class PhoneNumber
    {
        public PhoneNumber()
        {

        }

        public PhoneNumber( PhoneNumber? number)
        {
            
            Number = number;
        }

        // TODO: Implementation
        
        public PhoneNumber? Number { get; set; }
    }
}
