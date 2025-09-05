
using System;

namespace Inva.LawMax.Dtos;
public class HearingDto
{
    public Guid Id { get; set; }
    public DateTime HearingDate { get; set; }
    public string Notes { get; set; }
    public Guid CaseId { get; set; }
}
