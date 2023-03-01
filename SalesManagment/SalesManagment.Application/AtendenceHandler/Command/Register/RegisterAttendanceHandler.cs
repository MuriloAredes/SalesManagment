using MediatR;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Contract.AttendanceContracts.RegisterRequest;

namespace SalesManagment.Application.AtendenceHandler.Command.Register
{
    public class RegisterAttendanceHandler : IRequestHandler<RegisterAttendanceRequest>
    {
        private readonly IAttendanceRepository _attendanceRepository;
        public RegisterAttendanceHandler(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }
        // TODO: Apos a empresa for cadastrada  ela vai ser atendida por um vendedor da regiao dela 
        public Task<Unit> Handle(RegisterAttendanceRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
