namespace Domain;
using System.Text.Json.Serialization;

public record class Ticker
{
    [JsonPropertyName("Meta Data")]
    public MetaData MetaData { get; set; }
    [JsonPropertyName("Time Series (15min)")]
    public Dictionary<string, TimeSeriesEntry> TimeSeries { get; set; }
}