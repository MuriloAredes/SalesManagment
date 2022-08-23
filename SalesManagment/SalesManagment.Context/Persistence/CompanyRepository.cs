using SalesManagment.Context.Data;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Context.Repository;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.Persistence
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(DataContext context) : base(context)
        {
        }
    }
}
