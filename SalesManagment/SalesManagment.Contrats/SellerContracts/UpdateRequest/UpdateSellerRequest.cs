using MediatR;

namespace SalesManagment.Contract.SellerContracts.UpdateRequest
{
    public class UpdateSellerRequest: IRequest
    {
        public int id { get; set; }
    }
}
