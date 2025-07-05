using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain.Entities
{
    public abstract class BasicEntity
    {
        public Guid Id { get; set; }
        public int Sort { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
