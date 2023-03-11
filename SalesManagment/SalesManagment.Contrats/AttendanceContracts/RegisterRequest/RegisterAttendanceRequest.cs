using MediatR;

namespace SalesManagment.Contract.AttendanceContracts.RegisterRequest
{
    public class RegisterAttendanceRequest : IRequest<SucessMessage>
    {
        public int CompanyId { get; set; }
        public int SellerId { get; set; }      
        public DateTime Register { get; set; }
    }
}
