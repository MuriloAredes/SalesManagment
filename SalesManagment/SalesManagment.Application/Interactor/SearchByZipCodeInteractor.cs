using Newtonsoft.Json;
using SalesManagment.Application.Interactor.interfaces;
using SalesManagment.Domain.Dto;

namespace SalesManagment.Application.Interactor
{
    public class SearchByZipCodeInteractor : ISearchByZipCodeInteractor
    {
        public async Task<SearchResultCepDto> SearchByZipCode(string code)
        {
            using (var client =new HttpClient())
            {
                client.BaseAddress = new Uri("https://viacep.com.br");
                
                var response = await client.GetAsync($"/ws/{code}/json").ConfigureAwait(false);
                
                response.EnsureSuccessStatusCode();
                
                var result = await response.Content.ReadAsStringAsync();
                
                var adress = JsonConvert.DeserializeObject<SearchResultCepDto>(result);
                
                if (adress == null)
                    return new SearchResultCepDto();

                return adress;
            }
        }
    }
}
