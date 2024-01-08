using AutoMapper;
using Skoruba.AuditLogging.EntityFramework.Entities;
using Touride.IdentityPlatform.Admin.IdentityServer.Services.Dtos.Logdtos;
using Touride.IdentityPlatform.Data.Common;
using Touride.IdentityPlatform.Data.Entities;

namespace Touride.IdentityPlatform.Admin.IdentityServer.Services.Mappers
{
    public class LogMapperProfile : Profile
    {
        public LogMapperProfile()
        {
            CreateMap<Log, LogDto>(MemberList.Destination)
                .ReverseMap();

            CreateMap<PagedList<Log>, LogsDto>(MemberList.Destination)
                .ForMember(x => x.Logs, opt => opt.MapFrom(src => src.Data));

            CreateMap<AuditLog, AuditLogDto>(MemberList.Destination)
                .ReverseMap();

            CreateMap<PagedList<AuditLog>, AuditLogsDto>(MemberList.Destination)
                .ForMember(x => x.Logs, opt => opt.MapFrom(src => src.Data));
        }
    }
}
