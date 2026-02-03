using System.Net.Http.Json;

namespace SkiWeather;

// public class WeatherService
// {
//     private static readonly HttpClient http = new();

//     public static async Task<Forecast> GetForecastAsync(Resort resort)
//     {
//         var url = 
//             $"https://api.open-meteo.com/v1/forecast" +
//             $"?latitude={resort.Latitude}" +
//             $"&longitude={resort.Longitude}" +
//             $"&hourly=temperature_2m,snowfall" +
//             $"&temperature_unit=fahrenheit" +
//             $"&precipitation_unit=inch" +
//             $"&timezone=America%2FLos_Angeles";

//         var forecast = await http.GetFromJsonAsync<Forecast>(url);

//         if (forecast == null)
//             throw new Exception("Failed to get forecast data");

//         return forecast;

//     }
// }

public class WeatherService
{
    private readonly HttpClient _http;

    public WeatherService(HttpClient http)
    {
        _http = http;
    }

    public async Task<Forecast> GetForecastAsync(Resort resort)
    {
        var url =
            $"https://api.open-meteo.com/v1/forecast" +
            $"?latitude={resort.Latitude}" +
            $"&longitude={resort.Longitude}" +
            $"&hourly=temperature_2m,snowfall" +
            $"&temperature_unit=fahrenheit" +
            $"&precipitation_unit=inch" +
            $"&timezone=America%2FLos_Angeles";

        var forecast = await _http.GetFromJsonAsync<Forecast>(url);

        if (forecast == null)
            throw new Exception("Failed to get forecast data");

        return forecast;
    }
}