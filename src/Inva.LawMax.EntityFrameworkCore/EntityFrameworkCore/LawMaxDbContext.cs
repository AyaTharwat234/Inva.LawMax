
using Inva.LawMax.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Inva.LawMax.EntityFrameworkCore
{
    public class LawMaxDbContext : AbpDbContext<LawMaxDbContext>
    {
        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Hearing> Hearings { get; set; }

        public LawMaxDbContext(DbContextOptions<LawMaxDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigurePermissionManagement();
            builder.ConfigureSettingManagement();
            builder.ConfigureBackgroundJobs();
            builder.ConfigureAuditLogging();
            builder.ConfigureIdentity();
            builder.ConfigureOpenIddict();
            builder.ConfigureFeatureManagement();
            builder.ConfigureTenantManagement();
            builder.ConfigureLawMax();

            // Configure Lawyer
            builder.Entity<Lawyer>(b =>
            {
                b.ToTable("Lawyers");
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
                b.Property(x => x.LicenseNumber).HasMaxLength(50);
            });

            // Configure Case
            builder.Entity<Case>(b =>
            {
                b.ToTable("Cases");
                b.Property(x => x.Title).IsRequired().HasMaxLength(256);
                b.HasOne<Lawyer>()
                  .WithMany()
                  .HasForeignKey(x => x.LawyerId);
            });

            // Configure Hearing
            builder.Entity<Hearing>(b =>
            {
                b.ToTable("Hearings");
                b.Property(x => x.Notes).HasMaxLength(512);
                b.HasOne<Case>()
                  .WithMany()
                  .HasForeignKey(x => x.CaseId);
            });
        }
    }
}
