using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Inva.LawMax.Entities
{
    public class Hearing : FullAuditedAggregateRoot<Guid>
    {
        public DateTime HearingDate { get; set; }
        public string Notes { get; set; }
        public Guid CaseId { get; set; } // Foreign Key
    }
}

