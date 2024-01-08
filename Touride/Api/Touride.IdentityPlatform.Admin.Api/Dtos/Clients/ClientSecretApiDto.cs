using System;
using System.ComponentModel.DataAnnotations;
using Touride.IdentityPlatform.Data.Helpers;

namespace Touride.IdentityPlatform.Admin.Api.Dtos.Clients
{
    public class ClientSecretApiDto
    {
        [Required]
        public string Type { get; set; } = "SharedSecret";

        public int Id { get; set; }

        public string Description { get; set; }

        [Required]
        public string Value { get; set; }

        public string HashType { get; set; }

        public HashType HashTypeEnum => Enum.TryParse(HashType, true, out HashType result) ? result : Touride.IdentityPlatform.Data.Helpers.HashType.Sha256;

        public DateTime? Expiration { get; set; }
    }
}