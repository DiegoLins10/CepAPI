using Newtonsoft.Json;

namespace Cep.Entities
{
    class CepResponse
    {
        /*
         * Nosso objeto onde vai armazenar os atributos do Json
         * E nele usamos o Jsonproperty para vincular os atributos com o Json
         */
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("uf")]
        public string Uf { get; set; }
        [JsonProperty("siafi")]
        public string Siafi { get; set; }
        [JsonProperty("ibge")]
        public string Ibge { get; set; }
        [JsonProperty("gia")]
        public string Gia { get; set; }
        [JsonProperty("ddd")]
        public string Ddd { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
    }
}
