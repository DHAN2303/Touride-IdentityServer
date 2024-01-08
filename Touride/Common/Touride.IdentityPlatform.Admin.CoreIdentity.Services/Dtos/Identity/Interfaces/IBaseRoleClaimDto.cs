namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity.Interfaces
{
    public interface IBaseRoleClaimDto
    {
        int ClaimId { get; set; }
        object RoleId { get; }
    }
}
