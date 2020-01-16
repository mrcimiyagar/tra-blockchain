
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace TraBlockchain.Entities
{
    public class User
    {
        [Key]
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        
    }
}