using Newtonsoft.Json;

namespace SalesManagment.Domain.Dto
{

    public class Regiao
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("sigla")]
        public string Sigla { get; set; } = String.Empty;
        [JsonProperty("nome")]
        public string Nome { get; set; } = String.Empty;
    }

   
    public class RootDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("sigla")]
        public string Sigla { get; set; } = String.Empty;
        [JsonProperty("nome")]
        public string Nome { get; set; } = String.Empty;
        [JsonProperty("regiao")]
        public Regiao? Regiao { get; set; }
    }


}
