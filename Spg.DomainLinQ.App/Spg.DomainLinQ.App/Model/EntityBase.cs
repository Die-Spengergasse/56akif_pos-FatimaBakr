using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// Id
    /// LastChangeDate (?)
    /// </summary>
    /// (2P)
    public class EntityBase
    {
        protected EntityBase()
        {

        }
        public EntityBase(int id, DateTime? lastChangeDate)
        {
            Id = id;
            LastChangeDate = lastChangeDate;
        }

        public int Id { get; private set; }
        public DateTime? LastChangeDate { get; private set; }
        // TODO: Implementation
    }
}
