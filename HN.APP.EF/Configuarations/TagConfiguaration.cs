using HN.Data.EF.Extensions;
using HN.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace HN.Data.EF.Configuarations
{
    public class TagConfiguaration : DbEntityConfiguration<Tag>
    {
        public override void Configure(EntityTypeBuilder<Tag> entity)
        {
            entity.Property(c => c.Id).HasMaxLength(50)
                 .IsRequired().HasColumnType("varchar(50)");
        }
    }
}
