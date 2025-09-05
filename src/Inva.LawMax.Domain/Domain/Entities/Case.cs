using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Inva.LawMax.Entities
{
    public class Case : FullAuditedAggregateRoot<Guid>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid LawyerId { get; set; }  // Foreign Key
    }
}
