using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Inva.LawMax.EntityFrameworkCore;

public class LawMaxDbContextFactory : IDesignTimeDbContextFactory<LawMaxDbContext>
{
    public LawMaxDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<LawMaxDbContext>();

        var connectionString = configuration.GetConnectionString("Default");

        builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        return new LawMaxDbContext(builder.Options);
    }
}
