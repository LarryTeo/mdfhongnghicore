using HN.Infrastructure.ShareKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HN.Data.Entities
{
    public class ProductTag : DomainEntiy<int>
    {
        public int ProductId { get; set; }
        [StringLength(50)]
        [Column(TypeName="varchar50")]
        public string TagId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("TagId")]

        public virtual Tag Tag { get; set; }
    }
}
