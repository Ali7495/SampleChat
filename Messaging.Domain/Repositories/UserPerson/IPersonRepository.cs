using Messaging.Domain.Entities.UserPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain.Repositories.UserPerson
{
    public interface IPersonRepository : IRepository<Person>
    {
        Task<Person> GetOnlyById(Guid id, CancellationToken cancellationToken);
    }
}
