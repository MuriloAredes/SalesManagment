using Microsoft.EntityFrameworkCore;
using SalesManagment.Context.DataConfig;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.Data
{
    public class DataContext : DbContext
    {
        #region Entities 
        public virtual DbSet<Seller>? Sellers { get; set; } 
        public virtual DbSet<Company>? Companies { get; set; }
        public virtual DbSet<SellerRegion>? UsersRegions { get; set; }
        public virtual DbSet<Attendance>? Calls { get; set; }
        public virtual DbSet<MicroRegion>? MicroRegions { get; set; }
        public virtual DbSet<Region>? Regions { get; set; }
        #endregion    
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Seller>(new UserConfiguration().Configure);
            builder.Entity<Company>(new CompanyConfiguration().Configure);
            builder.Entity<SellerRegion>(new UserRegionConfiguration().Configure);
            builder.Entity<Attendance>(new AttendanceConfiguration().Configure);
            builder.Entity<Region>(new RegionConfiguration().Configure);
            builder.Entity<MicroRegion>(new MicroRegionConfiguration().Configure);

            base.OnModelCreating(builder);
        }
    }
}
