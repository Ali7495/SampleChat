using Messaging.Domain.Entities.UserPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain.Repositories.UserPerson
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetOnlyById(Guid id, CancellationToken cancellationToken);
    }
}
