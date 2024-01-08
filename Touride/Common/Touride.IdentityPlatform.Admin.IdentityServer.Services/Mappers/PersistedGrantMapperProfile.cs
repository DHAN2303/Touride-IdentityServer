using AutoMapper;
using IdentityServer4.EntityFramework.Entities;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Dtos.Grant;
using Touride.IdentityPlatform.Data.Common;
using Touride.IdentityPlatform.Data.Entities;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Mappers
{
    public class PersistedGrantMapperProfile : Profile
    {
        public PersistedGrantMapperProfile()
        {
            // entity to model
            CreateMap<PersistedGrant, PersistedGrantDto>(MemberList.Destination)
                .ReverseMap();

            CreateMap<PersistedGrantDataView, PersistedGrantDto>(MemberList.Destination);

            CreateMap<PagedList<PersistedGrantDataView>, PersistedGrantsDto>(MemberList.Destination)
                .ForMember(x => x.PersistedGrants,
                    opt => opt.MapFrom(src => src.Data));

            CreateMap<PagedList<PersistedGrant>, PersistedGrantsDto>(MemberList.Destination)
                .ForMember(x => x.PersistedGrants,
                    opt => opt.MapFrom(src => src.Data));
        }
    }
}
