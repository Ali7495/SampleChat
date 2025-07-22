using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Application.CQRS.Person.Command.Handlers
{
    public class PersonCommandHandler : IRequestHandler<PersonCommand, Guid>
    {
        public Task<Guid> Handle(PersonCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
