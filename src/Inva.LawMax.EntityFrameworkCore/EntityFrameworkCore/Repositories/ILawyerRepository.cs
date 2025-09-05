using Inva.LawMax.Entities;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Inva.LawMax
{
    public interface ILawyerRepository : IRepository<Lawyer, Guid>
    {
        Task<Lawyer> FindByLicenseNumberAsync(string licenseNumber);
    }
}
