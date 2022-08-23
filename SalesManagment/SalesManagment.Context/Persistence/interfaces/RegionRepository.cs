using SalesManagment.Context.Data;
using SalesManagment.Context.Repository;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.Persistence.interfaces
{
    public class RegionRepository : Repository<Region>, IRegionRepository
    {
        public RegionRepository(DataContext context) : base(context)
        {
        }
    }
}
