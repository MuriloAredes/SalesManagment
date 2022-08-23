using MediatR;

namespace SalesManagment.Contract.SellerContracts.RegisterRequest
{
    public class RegisterSellerRequest : IRequest<SucessMessage>
    {
        public string Email { get; set; } = String.Empty;
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Cep { get; set; } = String.Empty;
        public string Number { get; set; } = String.Empty;
        public string Complement { get; set; } = String.Empty;

    }
}
