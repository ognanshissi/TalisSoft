using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace TalisSoft.Common.Application
{
    public static class CommonApplicationServiceRegistration
    {
        public static IServiceCollection AddCommonApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}