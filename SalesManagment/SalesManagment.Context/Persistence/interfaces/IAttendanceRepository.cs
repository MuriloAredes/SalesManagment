using SalesManagment.Context.Repository;
using SalesManagment.Context.Repository.interfaces;
using SalesManagment.Domain.Entitites;

namespace SalesManagment.Context.Persistence.interfaces
{
    public interface IAttendanceRepository :IRepository<Attendance>
    {
    }
}
