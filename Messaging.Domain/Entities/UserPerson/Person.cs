using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain.Entities.UserPerson
{
    public class Person : BasicEntity
    {
        public string FirstName { get; set; }
        public string LasrName { get; set; }
        public string FullName { get; set; }



        public virtual List<User> Users { get; set; }
    }
}
