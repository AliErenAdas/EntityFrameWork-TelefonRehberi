using A_Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace C_Infrustructure.EntityTypeConfig
{
    public class GrupConfig : IEntityTypeConfiguration<Grup>
    {
        public void Configure(EntityTypeBuilder<Grup> builder)
        {
            builder.HasKey(x=> x.ID).IsClustered();
            builder.Property(x => x.ID).IsRequired(true).UseIdentityColumn(10, 1);
            builder.Property(x => x.GrupAdı).IsRequired(true).IsUnicode(true).HasMaxLength(25);
        }
    }
}
