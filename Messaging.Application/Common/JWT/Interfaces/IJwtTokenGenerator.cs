using Messaging.Domain.Entities.UserPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Application.Common.JWT.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}
