using MediatR;

namespace SalesManagment.Contract.SellerContracts.GetAllRequestAndResponse
{
    public class GetAllSellerRequest :IRequest<List<GetAllSellerResponse>>
    {
    }
}
