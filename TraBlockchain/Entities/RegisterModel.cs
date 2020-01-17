using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;


namespace TraBlockchain.Entities
{
    public class RegisterModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("email")]
        public string Email { get; set; }
        
        [JsonProperty("password")]
        public string Password { get; set; }
        
    }
}