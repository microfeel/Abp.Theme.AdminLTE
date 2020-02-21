using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MicroFeel.Abp.Theme.AdminLTEDemo.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AdminLTEDemoMigrationsDbContextFactory : IDesignTimeDbContextFactory<AdminLTEDemoMigrationsDbContext>
    {
        public AdminLTEDemoMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AdminLTEDemoMigrationsDbContext>()
                .UseMySql(configuration.GetConnectionString("Default"));

            return new AdminLTEDemoMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
