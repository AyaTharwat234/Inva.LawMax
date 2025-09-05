using System;
using System.Collections.Generic;
using System.Linq;
using Volo.Abp.Application.Dtos;


namespace Inva.LawMax.Dtos;
    public class LawyerDto : EntityDto<Guid>
{
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LicenseNumber { get; set; }
        public string Email { get; set; }
    }


