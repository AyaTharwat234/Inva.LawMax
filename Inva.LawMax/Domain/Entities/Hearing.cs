namespace Inva.LawMax.Domain.Entities
{
    using Abp.Domain.Entities.Auditing;
  

    namespace Inva.LawMax.LawCases
    {
        public class Hearing : FullAuditedAggregateRoot<Guid>
        {
            public DateTime Date { get; set; }
            public string Decision { get; set; }

            public Guid CaseId { get; set; }
            public Case Case { get; set; }
        }
    }

}
