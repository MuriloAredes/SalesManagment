using SalesManagment.Context.Data;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Context.Repository;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.Persistence
{
    public class SellerRegionRepository : Repository<SellerRegion>, ISellerRegionRepository
    {
        public SellerRegionRepository(DataContext context) : base(context)
        {
        }
    }
}
