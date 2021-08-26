using HN.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HN.Data.Entities
{
    [Table("Sizes")]
    public class Size : DomainEntiy<int>
    {

        [StringLength(250)]
        public string Name
        {
            get; set;
        }
    }
}
