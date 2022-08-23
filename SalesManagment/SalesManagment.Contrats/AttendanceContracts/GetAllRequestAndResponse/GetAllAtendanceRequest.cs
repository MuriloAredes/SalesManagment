using MediatR;
using SalesManagment.Contract.AttendanceContracts.GetAllRequestAndResponse;

namespace SalesManagment.Contract.AttendanceContracts.GetAllRequest
{
    public class GetAllAtendanceRequest:IRequest<List<GetAllAtendanceResponse>>
    {
    }
}
