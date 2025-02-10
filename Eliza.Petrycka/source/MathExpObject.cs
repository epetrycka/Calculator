using System.Text.Json.Serialization;

namespace intern25
{
    public class MathExpObject
    {
        [JsonPropertyName("operator")]
        public string Oper { get; set; } = string.Empty;

        [JsonPropertyName("value1")]
        public double? Value1 { get; set; }

        [JsonPropertyName("value2")]
        public double? Value2 { get; set; }
    }
}
