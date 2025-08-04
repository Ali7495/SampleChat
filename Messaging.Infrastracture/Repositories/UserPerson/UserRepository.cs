using Messaging.Domain.Entities.UserPerson;
using Messaging.Domain.Repositories.UserPerson;
using Messaging.Infrastracture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Infrastracture.Repositories.UserPerson
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(UserManagementDbContext userManagementDbContext) : base(userManagementDbContext)
        {
        }

        public async Task<User> GetOnlyById(Guid id, CancellationToken cancellationToken)
        {
            return await Entities.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
        }
    }
}
