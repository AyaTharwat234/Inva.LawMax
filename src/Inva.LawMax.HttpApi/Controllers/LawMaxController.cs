using Inva.LawMax.Dtos;

using Inva.LawMax.Localization;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.AspNetCore.Mvc;



namespace Inva.LawMax.Controllers;

[Route("api/lawyers")]
public class LawyerController : AbpController
{
    private readonly ILawyerAppService _service;

    public LawyerController(ILawyerAppService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public Task<LawyerDto> GetAsync(Guid id)
        => _service.GetAsync(id);

    [HttpGet]
    public Task<PagedResultDto<LawyerDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        => _service.GetListAsync(input);

    [HttpPost]
    public Task<LawyerDto> CreateAsync(CreateUpdateLawyerDto input)
        => _service.CreateAsync(input);

    [HttpPut("{id}")]
    public Task<LawyerDto> UpdateAsync(Guid id, CreateUpdateLawyerDto input)
        => _service.UpdateAsync(id, input);

    [HttpDelete("{id}")]
    public Task DeleteAsync(Guid id)
        => _service.DeleteAsync(id);
}


