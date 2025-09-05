// CaseAppService.cs
using Inva.LawMax.Dtos;
using Inva.LawMax.Entities;
using System;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Inva.LawMax.Services;
public class CaseAppService :
    CrudAppService<Case, CaseDto, Guid>,
    IApplicationService
{
    public CaseAppService(IRepository<Case, Guid> repository) : base(repository) { }
}

