using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain.Entities.UserPerson
{
    public class User : BasicEntity
    {

        public Guid PersonId { get; set; }
        public string Username { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string LowerUsername { get; set; }
        public string HashedPassword { get; set; }
        public bool IsActive { get; set; }
        public bool IsLocked { get; set; }


        public virtual Person Person { get; set; }
    }
}
