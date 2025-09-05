using Abp.EntityFrameworkCore;
using Inva.LawMax;
using Inva.LawMax.Entities;
using Inva.LawMax.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;

public class LawyerRepository : EfCoreRepository<LawMaxDbContext, Lawyer, Guid>, ILawyerRepository
{
    public LawyerRepository(IDbContextProvider<LawMaxDbContext> dbContextProvider)
        : base((Volo.Abp.EntityFrameworkCore.IDbContextProvider<LawMaxDbContext>)dbContextProvider)
    {
    }

    public Task<Lawyer> FindByLicenseNumberAsync(string licenseNumber)
    {
        throw new NotImplementedException();
    }

    // Only put custom queries here
}

