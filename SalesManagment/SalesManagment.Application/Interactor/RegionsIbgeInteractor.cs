using Newtonsoft.Json;
using SalesManagment.Application.Interactor.interfaces;
using SalesManagment.Domain.Dto;
using System.Net;

namespace SalesManagment.Application.Interactor
{
    public class RegionsIbgeInteractor : IRegionsIbgeInteractor
    {
        public async Task<List<RootDto>> GetAllRegion()
        {
            using (var http = new HttpClient())
            {

                string url = "https://servicodados.ibge.gov.br/api/v1/localidades/estados?orderBy=a";
                var json = await http.GetStringAsync(url);

                var regions = JsonConvert.DeserializeObject<List<RootDto>>(json);
               
                if (regions == null)
                    return new List<RootDto>();

                return regions;
            }
        }
    }
}
