using A_Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Infrustructure.EntityTypeConfig
{
    public class KisiGruplariConfig : IEntityTypeConfiguration<KisiGruplari>
    {
        public void Configure(EntityTypeBuilder<KisiGruplari> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired(true).UseIdentityColumn(10, 1);
            builder.HasOne(x => x.Kisi).WithMany(x => x.KisiGruplari).HasForeignKey(x => x.KisiID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Grup).WithMany(x => x.KisiGruplari).HasForeignKey(x => x.GrupID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
