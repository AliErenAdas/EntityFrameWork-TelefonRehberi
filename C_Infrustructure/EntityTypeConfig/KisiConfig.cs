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
    public class KisiConfig : IEntityTypeConfiguration<Kisi>
    {
        public void Configure(EntityTypeBuilder<Kisi> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired(true).UseIdentityColumn(10, 1);
            builder.Property(x => x.İsim).IsRequired(true).HasMaxLength(25);
            builder.Property(x => x.Adres).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.Açıklama).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.Soyisim).IsRequired(true).HasMaxLength(25); 
            builder.Property(x => x.NickName).IsRequired(true).HasMaxLength(25); 
            builder.Property(x => x.DoğumTarihi).HasConversion(typeof(DateTime)).IsRequired(false).HasDefaultValue(DateTime.Now); 
        }
    }
   
}
