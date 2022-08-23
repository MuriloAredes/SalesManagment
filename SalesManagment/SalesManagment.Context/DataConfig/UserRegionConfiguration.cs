using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagment.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagment.Context.DataConfig
{
    public class UserRegionConfiguration : IEntityTypeConfiguration<SellerRegion>
    {
        public void Configure(EntityTypeBuilder<SellerRegion> builder)
        {
            builder.ToTable("SellerRegions");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.SellerId)
                 .HasColumnType("int");

            builder.Property(e => e.Region)
                  .HasColumnType("int");

            builder.Property(e => e.Status)
                  .HasColumnType("bit");

            builder.HasOne(e => e.Seller)                
                .WithOne(e => e.SellerRegions)
                .HasForeignKey<SellerRegion>(x => x.SellerId);

        }
    }
}
