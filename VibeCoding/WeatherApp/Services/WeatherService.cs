using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using WeatherApp.Models;

namespace WeatherApp.Services;

public class WeatherService {
    private readonly HttpClient _httpClient;

    public WeatherService() {
        _httpClient = new HttpClient();
    }

    public async Task<WeatherData?> GetWeatherAsync() {
        string url =
            "https://api.open-meteo.com/v1/forecast" +
            "?latitude=35.6895" +
            "&longitude=139.6917" +
            "&current=temperature_2m,weather_code,relative_humidity_2m,wind_speed_10m";

        HttpResponseMessage response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string json = await response.Content.ReadAsStringAsync();
        OpenMeteoResponse? result = JsonSerializer.Deserialize<OpenMeteoResponse>(json);

        if(result == null) {
            return null;
        }

        return new WeatherData {
            Temperature = result.Current.Temperature2m,
            WeatherCode = result.Current.WeatherCode,
            Humidity = result.Current.Humidity,
            WindSpeed = result.Current.WindSpeed
        };
    }

    private class OpenMeteoResponse {
        [JsonPropertyName("current")]
        public CurrentWeather Current { get; set; } = null!;
    }

    private class CurrentWeather {
        [JsonPropertyName("temperature_2m")]
        public double Temperature2m { get; set; }

        [JsonPropertyName("weather_code")]
        public int WeatherCode { get; set; }

        [JsonPropertyName("relative_humidity_2m")]
        public int Humidity { get; set; }

        [JsonPropertyName("wind_speed_10m")]
        public double WindSpeed { get; set; }
    }
}