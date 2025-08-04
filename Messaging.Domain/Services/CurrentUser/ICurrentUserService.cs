using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain.Services.CurrentUser
{
    public interface ICurrentUserService
    {
        Guid? UserId { get; }
    }
}
