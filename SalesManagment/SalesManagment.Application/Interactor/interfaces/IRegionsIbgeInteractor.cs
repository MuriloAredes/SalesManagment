using SalesManagment.Domain.Dto;

namespace SalesManagment.Application.Interactor.interfaces
{
    public interface IRegionsIbgeInteractor
    {
        Task<List<RootDto>> GetAllRegion(); 
    }
}
