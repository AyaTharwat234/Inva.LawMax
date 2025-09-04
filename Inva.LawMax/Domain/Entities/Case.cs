using Abp.Domain.Entities.Auditing;
using Inva.LawMax.Domain.Entities.Inva.LawMax.LawCases;

namespace Inva.LawMax.Domain.Entities
{
        public class Case : FullAuditedAggregateRoot<Guid>
        {
            public string Number { get; set; }
            public int Year { get; set; }
            public string LitigationDegree { get; set; }
            public string FinalVerdict { get; set; }

            public ICollection<Hearing> Hearings { get; set; } = new List<Hearing>();
        }
    
}
