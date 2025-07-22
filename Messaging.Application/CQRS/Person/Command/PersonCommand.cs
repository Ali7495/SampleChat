using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Application.CQRS.Person.Command
{
    public class PersonCommand : IRequest<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " - " + LastName;
            }
        }
    }
}
