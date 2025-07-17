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
        }
    }
}
