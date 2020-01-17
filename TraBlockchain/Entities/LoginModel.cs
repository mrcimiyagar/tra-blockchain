using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;



namespace TraBlockchain.Entities
{
    public class LoginModel
    {
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("password")]
        public string Password { get; set; }
        

    }
}