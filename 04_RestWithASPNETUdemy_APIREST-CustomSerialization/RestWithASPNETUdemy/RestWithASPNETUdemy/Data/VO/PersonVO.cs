
using System.Text.Json.Serialization;

namespace RestWithASPNETUdemy.Data.VO
{
    public class PersonVO
    {
        [JsonPropertyName("Identificador")]
        public long Id { get; set; }
        [JsonPropertyName("Nome")]
        public string FirstName { get; set; }
        [JsonPropertyName("Sobrenome")]
        public string LastName { get; set; }
        [JsonPropertyName("Endereço")]
        public string Address { get; set; }
        [JsonPropertyName("Genero")]
        public string Gender { get; set; }
    }
}
