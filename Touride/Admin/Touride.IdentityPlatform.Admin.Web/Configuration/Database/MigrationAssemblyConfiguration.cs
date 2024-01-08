using System;
using System.Reflection;
//using MySqlMigrationAssembly = Touride.IdentityPlatform.Data.Providers.MySql.Helpers.MigrationAssembly;
//using PostgreSQLMigrationAssembly = Touride.IdentityPlatform.Data.Providers.PostgreSQL.Helpers.MigrationAssembly;
using Touride.IdentityPlatform.Data.Configuration;
using SqlMigrationAssembly = Touride.IdentityPlatform.Data.Providers.SqlServer.Helpers.MigrationAssembly;

namespace Touride.IdentityPlatform.Admin.Web.Configuration.Database
{
    public static class MigrationAssemblyConfiguration
    {
        public static string GetMigrationAssemblyByProvider(DatabaseProviderConfiguration databaseProvider)
        {
            return databaseProvider.ProviderType switch
            {
                DatabaseProviderType.SqlServer => typeof(SqlMigrationAssembly).GetTypeInfo().Assembly.GetName().Name,
                //DatabaseProviderType.PostgreSQL => typeof(PostgreSQLMigrationAssembly).GetTypeInfo()
                //    .Assembly.GetName()
                //    .Name,
                //DatabaseProviderType.MySql => typeof(MySqlMigrationAssembly).GetTypeInfo().Assembly.GetName().Name,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}