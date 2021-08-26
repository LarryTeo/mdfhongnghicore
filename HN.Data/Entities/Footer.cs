using HN.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HN.Data.Entities
{
    [Table("Footers")]
    public class Footer : DomainEntiy<string>
    {

        [Required]
        public string Content { set; get; }
    }
}
