using Inva.LawMax.Entities;
using Microsoft.EntityFrameworkCore;

using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;


namespace Inva.LawMax.EntityFrameworkCore
{
    public static class LawMaxDbContextModelCreatingExtensions
    {
        public static void ConfigureLawMax(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Lawyer>(b =>
            {
                b.ToTable("Lawyers");
                b.ConfigureByConvention();
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });

            builder.Entity<Case>(b =>
            {
                b.ToTable("Cases");
                b.ConfigureByConvention();
                b.Property(x => x.Title).IsRequired().HasMaxLength(256);
            });

            builder.Entity<Hearing>(b =>
            {
                b.ToTable("Hearings");
                b.ConfigureByConvention();
            });
        }
    }
}

