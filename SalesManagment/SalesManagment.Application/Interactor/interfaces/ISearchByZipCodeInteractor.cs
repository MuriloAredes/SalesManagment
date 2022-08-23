using SalesManagment.Domain.Dto;

namespace SalesManagment.Application.Interactor.interfaces
{
    public interface ISearchByZipCodeInteractor
    {
        Task<SearchResultCepDto> SearchByZipCode(string code);
    }
}
