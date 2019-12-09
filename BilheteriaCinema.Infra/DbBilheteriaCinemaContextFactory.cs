using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BilheteriaCinema.Infra.EF
{
    public class DbBilheteriaCinemaContextFactory : IDesignTimeDbContextFactory<DbBilheteriaCinemaContext>
    {
        public DbBilheteriaCinemaContext CreateDbContext(string[] args)
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            environment = string.IsNullOrEmpty(environment) ? "Development" : environment;
            
            var configuration = new ConfigurationBuilder()
                .SetBasePath($"{Directory.GetParent(".").FullName}/BilheteriaCinema")
                .AddJsonFile($"appsettings.{environment}.json")
                .Build();

            var connectionString = configuration.GetConnectionString("SqlConnection");
            
            var optionsBuilder = new DbContextOptionsBuilder<DbBilheteriaCinemaContext>();

            optionsBuilder.UseSqlServer(connectionString);
                
            return new DbBilheteriaCinemaContext(optionsBuilder.Options);
        }
    }
}