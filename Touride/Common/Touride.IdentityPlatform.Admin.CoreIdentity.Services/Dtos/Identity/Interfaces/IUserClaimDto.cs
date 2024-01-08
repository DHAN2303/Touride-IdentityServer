namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity.Interfaces
{
    public interface IUserClaimDto : IBaseUserClaimDto
    {
        string ClaimType { get; set; }
        string ClaimValue { get; set; }
    }
}
