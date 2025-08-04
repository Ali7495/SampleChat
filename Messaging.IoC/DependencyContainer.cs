using FluentValidation;
using Messaging.Application.Common;
using Messaging.Application.Common.FluentValidators;
using Messaging.Application.CQRS.Person.Command;
using Messaging.Domain.Services.CurrentUser;
using Messaging.Domain.UnitOfWorkPattern;
using Messaging.Infrastracture.UnitOfWorkPattern;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region UnitOfWork

            services.AddScoped<IUnitOfWork,UnitOfWork>();

            #endregion

            #region Packages

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(PersonCommand).Assembly));
            services.AddAutoMapper(cfg=> cfg.AddProfile<MappingProfile>());
            services.AddValidatorsFromAssembly(typeof(PersonValidator).Assembly);

            #endregion

            #region Utilities

            services.AddScoped<ICurrentUserService, CurrentUserService>();

            #endregion
        }
    }
}
