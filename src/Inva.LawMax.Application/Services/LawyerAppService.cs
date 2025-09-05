using Inva.LawMax;
using Inva.LawMax.Dtos;
using Inva.LawMax.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

using Volo.Abp.Domain.Repositories;

public class LawyerAppService : ApplicationService,
    IReadOnlyAppService<LawyerDto, LawyerDto, Guid, PagedAndSortedResultRequestDto>
{
    private readonly ILawyerRepository _lawyerRepository;

    public LawyerAppService(ILawyerRepository lawyerRepository)
    {
        _lawyerRepository = lawyerRepository;
    }

    public async Task<LawyerDto> GetAsync(Guid id)
    {
        var lawyer = await _lawyerRepository.GetAsync(id);
        return ObjectMapper.Map<Lawyer, LawyerDto>(lawyer);
    }

    public async Task<PagedResultDto<LawyerDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        var totalCount = await _lawyerRepository.GetCountAsync();

        var items = await _lawyerRepository.GetPagedListAsync(
            input.SkipCount,
            input.MaxResultCount,
            input.Sorting
        );

        return new PagedResultDto<LawyerDto>(
            totalCount,
            ObjectMapper.Map<List<Lawyer>, List<LawyerDto>>(items)
        );
    }

}

