using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace TalisSoft.Octopus.Application
{
    public static class OctopusApplicationRegistration
    {
        public static IServiceCollection AddOctopusApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}