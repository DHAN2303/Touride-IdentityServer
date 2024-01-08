﻿using System.Collections.Generic;
using System.Linq;
using Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity.Interfaces;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity
{
    public class UserProvidersDto<TUserProviderDto, TKey> : UserProviderDto<TKey>, IUserProvidersDto
        where TUserProviderDto : UserProviderDto<TKey>
    {
        public UserProvidersDto()
        {
            Providers = new List<TUserProviderDto>();
        }

        public List<TUserProviderDto> Providers { get; set; }

        List<IUserProviderDto> IUserProvidersDto.Providers => Providers.Cast<IUserProviderDto>().ToList();
    }
}
