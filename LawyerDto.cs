using Abp.Application.Services.Dto;
using System;

namespace Inva.LawMax.Dtos
{
    // Ensure LawyerDto inherits from EntityDto<Guid>
    public class LawyerDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
        public string Email { get; set; }
    }
}
using Abp.Application.Services.Dto;
using System;

namespace Inva.LawMax.Dtos
{
    // Ensure CreateUpdateLawyerDto inherits from EntityDto<Guid>
    public class CreateUpdateLawyerDto : EntityDto<Guid>
    {
        public string FullName { get; set; }
        public string LicenseNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}

