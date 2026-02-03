using System.Text.Json.Serialization;

namespace PopulationAnalyzer
{
    public class Indicator
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class Country
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class PopulationRecord
    {
        [JsonPropertyName("indicator")]
        public Indicator Indicator { get; set; }

        [JsonPropertyName("country")]
        public Country Country { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("decimal")]
        public string Decimal { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        public long GetPopulation()
        {
            if (long.TryParse(Value, out long result))
            {
                return result;
            }
            return 0;
        }
    }
}
