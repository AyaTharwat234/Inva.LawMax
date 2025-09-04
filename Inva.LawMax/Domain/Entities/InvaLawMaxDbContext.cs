using Inva.LawMax.Domain.Entities.Inva.LawMax.LawCases;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Inva.LawMax.Domain.Entities
{
    public class InvaLawMaxDbContext : DbContext
    {
        public InvaLawMaxDbContext(DbContextOptions<InvaLawMaxDbContext> options)
            : base(options)
        {
        }

        public DbSet<Lawyer> Lawyers { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Hearing> Hearings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Case>()
                .HasMany(c => c.Hearings)
                .WithOne(h => h.Case)
                .HasForeignKey(h => h.CaseId);
        }
    }

}
