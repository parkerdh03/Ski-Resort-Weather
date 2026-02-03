using System.Text.Json.Serialization;

namespace SkiWeather;

public class Forecast
{
    [JsonPropertyName("hourly")]
    public Hourly Hourly { get; set; } = default!;
}

public class Hourly
{
    [JsonPropertyName("time")]
    public List<string> Time { get; set; } = default!;

    [JsonPropertyName("temperature_2m")]
    public List<double> Temperature2m { get; set; } = default!;

    [JsonPropertyName("snowfall")]
    public List<double> Snowfall { get; set; } = default!;
}