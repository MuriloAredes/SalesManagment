using Newtonsoft.Json;

namespace SalesManagment.Domain.Dto
{
    public class SearchResultCepDto
    {
        [JsonProperty("cep")]
        public string Cep { get; set; } = string.Empty;

        [JsonProperty("logradouro")]
        public string Rua { get; set; } = string.Empty;

        [JsonProperty("complemento")]
        public string Complemento { get; set; } = string.Empty;

        [JsonProperty("bairro")]
        public string Bairro { get; set; } = string.Empty;

        [JsonProperty("localidade")]
        public string Cidade { get; set; } = string.Empty;

        [JsonProperty("uf")]
        public string EstadoUf { get; set; } = string.Empty;
    }
}
