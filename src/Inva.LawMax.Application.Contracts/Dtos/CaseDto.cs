
using System;

namespace Inva.LawMax.Dtos;
public class CaseDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Guid LawyerId { get; set; }
}
