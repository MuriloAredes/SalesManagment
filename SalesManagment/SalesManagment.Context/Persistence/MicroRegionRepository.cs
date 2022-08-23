using SalesManagment.Context.Data;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Context.Repository;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.Persistence
{
    public class MicroRegionRepository : Repository<MicroRegion> ,IMicroRegionRepository
    {
        public MicroRegionRepository(DataContext context) : base(context)
        {
        }
    }
}
