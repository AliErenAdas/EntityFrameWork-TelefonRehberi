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
    public class MailConfig : IEntityTypeConfiguration<Mail>
    {
        public void Configure(EntityTypeBuilder<Mail> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired(true).UseIdentityColumn(10, 1);
            builder.Property(x => x.MailAdresi).IsRequired(false).HasMaxLength(350);
            builder.HasOne(x => x.Kisi).WithMany(x => x.Mailler).HasForeignKey(x => x.KisiID).OnDelete(DeleteBehavior.Restrict);
        }
    }
   
}
