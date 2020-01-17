using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;



namespace TraBlockchain.Entities
{
    public class LoginModel
    {
        
        [JsonProperty("email")]
        public string Email { get; set; }
        
        [JsonProperty("password")]
        public string Password { get; set; }
        

    }
}