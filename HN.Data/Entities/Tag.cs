using HN.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HN.Data.Entities
{
    public class Tag : DomainEntiy<string>
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
    }
}
