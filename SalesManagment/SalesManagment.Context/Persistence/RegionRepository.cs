using SalesManagment.Context.Data;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Context.Repository;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.Persistence
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        public RegionRepository(DataContext context) : base(context)
        {
        }
    }
}
