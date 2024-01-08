using System.ComponentModel.DataAnnotations;
using Touride.IdentityPlatform.IdentityServer.Common.Configuration.Identity;

namespace Touride.IdentityPlatform.IdentityServer.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        public LoginResolutionPolicy? Policy { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Username { get; set; }
    }
}
