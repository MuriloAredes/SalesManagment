using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.DataConfig
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.ToTable("Regions");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Sigla)
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Nome)
                .HasColumnType("varchar(50)");

            builder.HasMany(e => e.MicroRegions);
        }
    }
}
