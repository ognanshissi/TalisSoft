using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TalisSoft.Common.Application.Contracts.Persistence;
using TalisSoft.Common.Persistence.Repositories;
using TalisSoft.Octopus.Application.Contracts.Persistence;
using TalisSoft.Octopus.Persistence.Repositories;

namespace TalisSoft.Octopus.Persistence
{
    public static class OctopusPersistenceRegistration
    {
        public static IServiceCollection AddOctopusPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OctopusDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("OctopusConnectionString")));
            
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<,>));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            return services;
        }
    }
}