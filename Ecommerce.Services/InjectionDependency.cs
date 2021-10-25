using Ecommerce.DataAccess;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Services
{
    public static class InjectionDependency
    {
        public static IServiceCollection AddInjection(this IServiceCollection services)
        {
            return services.AddTransient<ICustomerRepository, CustomerRepository>()
                .AddTransient<ICustomerService, CustomerService>(); 
        }
    }
}
