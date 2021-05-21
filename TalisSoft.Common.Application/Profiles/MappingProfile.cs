using AutoMapper;
using TalisSoft.Common.Application.Queries;
using TalisSoft.Common.Domain.Filters;

namespace TalisSoft.Common.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<PaginationQuery, PaginationFilter>();
        }
    }
}