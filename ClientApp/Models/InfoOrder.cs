using System.Text.Json.Serialization;

namespace ClientApp.Models
{
    public class InfoOrder
    {
        [JsonPropertyName("Name")]
        public object Name { get; set; }
        
        [JsonPropertyName("Street")]
        public string Street { get; set; }
        
        [JsonPropertyName("Number")]
        public int Number { get; set; }
        
        [JsonPropertyName("Town")]
        public string Town { get; set; }
        
        [JsonPropertyName("PhoneNumber")]
        public int phoneNumber { get; set; }
        
        [JsonPropertyName("completed")]
        public object IsCompleted { get; set; }
        
    }
}