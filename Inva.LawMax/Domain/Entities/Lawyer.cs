using Abp.Domain.Entities.Auditing;

namespace Inva.LawMax.Domain.Entities
{
    public class Lawyer: FullAuditedAggregateRoot<Guid>
    {

        public string Name { get; set; }
        public string Position { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}
