using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Inva.LawMax.Entities
{
    public class Lawyer : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
        public string Email { get; set; }
    }
}

