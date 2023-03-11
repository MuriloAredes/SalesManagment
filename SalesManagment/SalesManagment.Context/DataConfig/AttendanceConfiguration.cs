using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.DataConfig
{
    public class AttendanceConfiguration : IEntityTypeConfiguration<Attendance>
    {
        public void Configure(EntityTypeBuilder<Attendance> builder)
        {
            builder.ToTable("Attendances");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.CompanyId)
                 .HasColumnType("int");

            builder.Property(e => e.SellerId)
                  .HasColumnType("int");

            builder.Property(e => e.Message)
                  .HasColumnType("varchar(250)");
           
            builder.Property(e => e.StatusAttendance)
                  .HasColumnType("int");

            builder.Property(e => e.Nota)
                  .HasColumnType("int");

            builder.Property(e => e.Register)
                  .HasColumnType("DateTime");

            builder.HasOne(e => e.User)
                .WithMany(e => e.Attendances)
                .HasForeignKey(x => x.SellerId); 

            builder.HasOne(e => e.Company)
               .WithMany(e => e.Attendances)
               .HasForeignKey(x => x.CompanyId);

            builder.Navigation(e => e.User)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            builder.Navigation(e => e.Company)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

        }
    }
}
