using MediatR;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Contract.SellerContracts.UpdateRequest;

namespace SalesManagment.Application.Seller.Command.Update
{
    public class UpdateSellerHandler : IRequestHandler<UpdateSellerRequest>
    {
        private readonly ISellerRepository  _sellerRepository;
        public UpdateSellerHandler(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }

        public Task Handle(UpdateSellerRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
