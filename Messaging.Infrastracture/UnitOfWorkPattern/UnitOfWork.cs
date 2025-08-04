using Messaging.Domain.Repositories.UserPerson;
using Messaging.Domain.UnitOfWorkPattern;
using Messaging.Infrastracture.Data;
using Messaging.Infrastracture.Repositories.UserPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Infrastracture.UnitOfWorkPattern
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly UserManagementDbContext _dbContext;

        #region UserPerson

        public IPersonRepository PersonRepository { get; private set; }
        public IUserRepository UserRepository { get; private set; }


        #endregion

        public UnitOfWork(UserManagementDbContext dbContext)
        {
            _dbContext = dbContext;

            #region UserPerson

            PersonRepository = new PersonRepository(dbContext);
            UserRepository = new UserRepository(dbContext);

            #endregion
        }

        public void CompleteTask()
        {
            _dbContext.SaveChanges();
        }

        public async Task CompleteTaskAsync(CancellationToken cancellationToken)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async Task DisposeAsync()
        {
            await _dbContext.DisposeAsync();
        }
    }
}
