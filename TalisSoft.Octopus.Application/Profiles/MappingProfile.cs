using AutoMapper;
using TalisSoft.Octopus.Application.Features.Customers.Queries.GetCustomerList;
using TalisSoft.Octopus.Domain.Entities;

namespace TalisSoft.Octopus.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerListVm>().ReverseMap();
        }
    }
}