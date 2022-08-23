using SalesManagment.Context.Data;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Context.Repository;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.Persistence
{
    public class SellerRepository : Repository<Seller>, ISellerRepository
    {
        public SellerRepository(DataContext context) : base(context)
        {
        }
    }
}
