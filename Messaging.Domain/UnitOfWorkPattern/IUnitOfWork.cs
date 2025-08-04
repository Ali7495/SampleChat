using Messaging.Domain.Repositories.UserPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain.UnitOfWorkPattern
{
    public interface IUnitOfWork
    {

        #region UserPerson

        IPersonRepository PersonRepository { get; }
        IUserRepository UserRepository { get; }

        #endregion


        Task CompleteTaskAsync(CancellationToken cancellationToken);
        void CompleteTask();

        Task DisposeAsync();
        void Dispose();
    }
}
