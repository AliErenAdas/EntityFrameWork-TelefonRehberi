using A_Domain.Entity;
using A_Domain.Entity.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace C_Infrustructure.EntityTypeConfig
{

    public class İletişimTürConfig : IEntityTypeConfiguration<İletişimTür>
    {
        public void Configure(EntityTypeBuilder<İletişimTür> builder)
        {
            builder.HasKey(x => x.ID).IsClustered(true);
            builder.Property(x => x.ID).IsRequired(true).UseIdentityColumn(10, 1);
            builder.HasMany(x => x.iletişimNumaralarin).WithOne(x => x.Türü).HasForeignKey(x => x.TürID).OnDelete(DeleteBehavior.Restrict);
            builder.Property(x => x.iletişimNoTür).HasConversion(v => v.ToString(), v => (İletişimNoTür)Enum.Parse(typeof(İletişimNoTür), v));


        }
    }
}
