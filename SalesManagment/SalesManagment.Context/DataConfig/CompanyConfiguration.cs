using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.DataConfig
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Companies");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Cnpj)
                 .HasColumnType("varchar(20)");

            builder.Property(e => e.SocialReason)
                  .HasColumnType("varchar(50)");

            builder.Property(e => e.Uf)
                 .HasColumnType("varchar(20)");

            builder.Property(e => e.Situation)
                 .HasColumnType("varchar(20)");

            builder.Property(e => e.Description)
                .HasColumnType("varchar(20)");

            
        }
    }
}
