// HearingAppService.cs
using Inva.LawMax.Dtos;
using Inva.LawMax.Entities;
using System;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Inva.LawMax.Services;
public class HearingAppService :
    CrudAppService<Hearing, HearingDto, Guid>,
    IApplicationService
{
    public HearingAppService(IRepository<Hearing, Guid> repository) : base(repository) { }
}

