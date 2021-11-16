using System.Text.Json.Serialization;

namespace OrderSummary.Models
{
    public class Summary
    {
        [JsonPropertyName("Items")]
        public string Items { get; set; } = null!;
        [JsonPropertyName("Quantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("Price")]
        public int Price { get; set; }
        [JsonPropertyName("Total")]
        public int Total { get; set; }
        
        [JsonPropertyName("completed")]
        public bool IsCompleted { get; set; }
    }
}