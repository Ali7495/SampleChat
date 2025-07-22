using AutoMapper;
using Messaging.Application.CQRS.Person.Command;
using Messaging.Domain.Entities.UserPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Application.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PersonCommand, Person>();
        }
    }
}
