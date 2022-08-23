using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.DataConfig
{
    public class MicroRegionConfiguration : IEntityTypeConfiguration<MicroRegion>
    {
        public void Configure(EntityTypeBuilder<MicroRegion> builder)
        {
            builder.ToTable("MicroRegions");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Sigla)
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Nome)
                .HasColumnType("varchar(50)");

            builder.Property(e => e.RegionId)
               .HasColumnType("int");

            builder.HasOne(e => e.Region)
                   .WithMany(e => e.MicroRegions)
                   .HasForeignKey(e => e.RegionId);
        }
    }
}
