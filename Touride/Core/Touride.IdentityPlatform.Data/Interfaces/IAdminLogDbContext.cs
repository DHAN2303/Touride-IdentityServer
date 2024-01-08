using Microsoft.EntityFrameworkCore;
using Touride.IdentityPlatform.Data.Entities;

namespace Touride.IdentityPlatform.Data.Interfaces
{
    public interface IAdminLogDbContext
    {
        DbSet<Log> Logs { get; set; }
    }
}
