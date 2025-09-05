using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Inva.LawMax.Dtos
{
    public class CreateUpdateLawyerDto: EntityDto<Guid>
    {
        [Required]
        [StringLength(128)]
        public string FullName { get; set; }

        [Required]
        [StringLength(64)]
        public string LicenseNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
    }
}
