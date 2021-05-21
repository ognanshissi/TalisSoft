using TalisSoft.Common.Persistence.Repositories;
using TalisSoft.Octopus.Application.Contracts.Persistence;
using TalisSoft.Octopus.Domain.Entities;

namespace TalisSoft.Octopus.Persistence.Repositories
{
    public class CustomerRepository: BaseRepository<Customer, OctopusDbContext>, ICustomerRepository
    {
        public CustomerRepository(OctopusDbContext context) : base(context)
        {
        }
    }
}