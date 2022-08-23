using MediatR;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Contract.AttendanceContracts.GetAllRequest;
using SalesManagment.Contract.AttendanceContracts.GetAllRequestAndResponse;

namespace SalesManagment.Application.AtendenceHandler.Querie.GetAll
{
    internal class GetAllAttendenceHandler : IRequestHandler<GetAllAtendanceRequest, List<GetAllAtendanceResponse>>
    {
        private readonly IAttendanceRepository _attendanceRepository;
        public GetAllAttendenceHandler(IAttendanceRepository attendanceRepository)
        {
            _attendanceRepository = attendanceRepository;
        }

        public Task<List<GetAllAtendanceResponse>> Handle(GetAllAtendanceRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
