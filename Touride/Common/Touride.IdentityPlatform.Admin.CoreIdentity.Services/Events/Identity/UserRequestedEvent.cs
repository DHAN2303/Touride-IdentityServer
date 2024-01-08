using Skoruba.AuditLogging.Events;
using Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity;

namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Events.Identity
{
    public class UserRequestedEvent<TUserDto> : AuditEvent
    {
        public TUserDto UserDto { get; set; }

        public UserRequestedEvent(TUserDto userDto)
        {
            UserDto = userDto;
        }
    }
}