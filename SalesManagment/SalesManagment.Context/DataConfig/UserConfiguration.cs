using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.DataConfig
{
    public class UserConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(e => e.Id);
            builder.Property(k => k.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                   .HasColumnType("varchar(50)");

            builder.Property(e => e.Email)
                   .HasColumnType("varchar(50)");

            

            
        }
    }
}
