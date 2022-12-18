using A_Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace C_Infrustructure.EntityTypeConfig
{

    public class İletişimNumarasıConfig : IEntityTypeConfiguration<İletişimNumarası>
    {
        public void Configure(EntityTypeBuilder<İletişimNumarası> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).IsRequired(true).UseIdentityColumn(10, 1);
            builder.HasOne(x => x.Kisi).WithMany(x => x.IletisimNumaralari).HasForeignKey(x => x.KisiID).OnDelete(DeleteBehavior.Restrict);
            builder.Property(x => x.Numara).IsRequired(true);

        }
    }
}
