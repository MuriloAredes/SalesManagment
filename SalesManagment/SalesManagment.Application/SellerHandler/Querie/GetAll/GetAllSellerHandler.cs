using MediatR;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Contract.SellerContracts.GetAllRequestAndResponse;

namespace SalesManagment.Application.Seller.Querie.GetAll
{
    internal class GetAllSellerHandler : IRequestHandler<GetAllSellerRequest, List<GetAllSellerResponse>>
    {
        private readonly ISellerRepository _sellerRepository;
        public GetAllSellerHandler(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }
        public Task<List<GetAllSellerResponse>> Handle(GetAllSellerRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
