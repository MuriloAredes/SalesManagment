using MediatR;

namespace SalesManagment.Contract.RegionContracts
{
    public record RegionRequest(bool Done) : IRequest<SucessMessage>;
   
}
