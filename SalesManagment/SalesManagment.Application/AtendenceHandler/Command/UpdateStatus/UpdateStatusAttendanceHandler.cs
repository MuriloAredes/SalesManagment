using MediatR;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Contract.AttendanceContracts.UpdateStatusRequest;

namespace SalesManagment.Application.AtendenceHandler.Command.UpdateStatus
{
    internal class UpdateStatusAttendanceHandler : IRequestHandler<UpdateStatusAttendanceRequest>
    {
        private readonly IAttendanceRepository _attendanceRepository;
        public UpdateStatusAttendanceHandler(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;

        }
        public Task<Unit> Handle(UpdateStatusAttendanceRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
