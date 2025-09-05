
using Inva.LawMax.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Inva.LawMax;

public interface ILawyerAppService :
    ICrudAppService<
        LawyerDto,                 // IEntityDto<Guid>
        Guid,                      // Primary key
        PagedAndSortedResultRequestDto, // For list queries
        CreateUpdateLawyerDto,     // Create input
        CreateUpdateLawyerDto      // Update input
    >
{
}


