using System.Text.Json.Serialization;

namespace OrderSummary.Models
{
    public class InfoOrder
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; } = null!;
        
        [JsonPropertyName("Street")]
        public string Street { get; set; }
        [JsonPropertyName("Number")]
        public int Number { get; set; }
        [JsonPropertyName("Town")]
        public string Town { get; set; }
        [JsonPropertyName("Phone Number")]
        public int PhoneNumber { get; set; }
        
        [JsonPropertyName("completed")]
        public bool IsCompleted { get; set; }
    }
}