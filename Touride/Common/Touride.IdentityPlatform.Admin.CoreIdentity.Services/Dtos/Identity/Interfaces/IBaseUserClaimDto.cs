namespace Touride.IdentityPlatform.Admin.CoreIdentity.Services.Dtos.Identity.Interfaces
{
    public interface IBaseUserClaimDto
    {
        int ClaimId { get; set; }
        object UserId { get; }
    }
}
