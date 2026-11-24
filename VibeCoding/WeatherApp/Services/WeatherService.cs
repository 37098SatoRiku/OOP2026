using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using WeatherApp.Models;

namespace WeatherApp.Services;

public class WeatherService {
    private readonly HttpClient _httpClient;
    public string ErrorMessage { get; private set; } = "";


    public WeatherService() {
        _httpClient = new HttpClient();
    }

    public async Task<WeatherData?> GetWeatherAsync(double latitude, double longitude) {
        ErrorMessage = "";
        try {
            string url =
                "https://api.open-meteo.com/v1/forecast" +
                $"?latitude={latitude}" +
                $"&longitude={longitude}" +
                "&current=temperature_2m,weather_code,relative_humidity_2m,wind_speed_10m" +
                "&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max" +
                "&forecast_days=7" +
                "&timezone=Asia/Tokyo";

            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            OpenMeteoResponse? result = JsonSerializer.Deserialize<OpenMeteoResponse>(json);

            if(result == null) {
                return null;
            }

            List<DailyForecast> forecasts = [];

            for(int i = 0; i < result.Daily.Time.Length; i++) {
                forecasts.Add(new DailyForecast {
                    Date = result.Daily.Time[i],
                    WeatherCode = result.Daily.WeatherCode[i],
                    WeatherDescription = GetWeatherDescription(result.Daily.WeatherCode[i]),
                    MaxTemperature = result.Daily.MaxTemperature[i],
                    MinTemperature = result.Daily.MinTemperature[i],
                    PrecipitationProbability = result.Daily.PrecipitationProbability[i]
                });
            }

            return new WeatherData {
                Temperature = result.Current.Temperature2m,
                WeatherCode = result.Current.WeatherCode,
                WeatherDescription = GetWeatherDescription(result.Current.WeatherCode),
                Humidity = result.Current.Humidity,
                WindSpeed = result.Current.WindSpeed,
                DailyForecasts = forecasts
            };

        } catch(HttpRequestException ex) {
            ErrorMessage =
                "サーバーとの通信に失敗しました。\n" +
                ex.Message;

            return null;
        } catch(TaskCanceledException) {
            ErrorMessage =
                "通信がタイムアウトしました。";

            return null;
        } catch(Exception ex) {
            ErrorMessage =
                "予期しないエラーが発生しました。\n" +
                ex.Message;

            return null;
        }
    }

    private string GetWeatherDescription(int code) {
        return code switch {
            0 => "快晴",
            1 => "晴れ",
            2 => "薄曇り",
            3 => "曇り",

            45 => "霧",
            48 => "着氷性の霧",

            51 => "弱い霧雨",
            53 => "霧雨",
            55 => "強い霧雨",

            61 => "弱い雨",
            63 => "雨",
            65 => "強い雨",

            71 => "弱い雪",
            73 => "雪",
            75 => "大雪",

            80 => "にわか雨",
            81 => "強いにわか雨",
            82 => "激しいにわか雨",

            95 => "雷雨",
            96 => "雷雨（ひょう）",
            99 => "激しい雷雨",

            _ => "不明"
        };
    }

    private class OpenMeteoResponse {
        [JsonPropertyName("current")]
        public CurrentWeather Current { get; set; } = null!;

        [JsonPropertyName("daily")]
        public DailyWeather Daily { get; set; } = null!;
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

    private class DailyWeather {
        [JsonPropertyName("time")]
        public string[] Time { get; set; } = [];

        [JsonPropertyName("weather_code")]
        public int[] WeatherCode { get; set; } = [];

        [JsonPropertyName("temperature_2m_max")]
        public double[] MaxTemperature { get; set; } = [];

        [JsonPropertyName("temperature_2m_min")]
        public double[] MinTemperature { get; set; } = [];

        [JsonPropertyName("precipitation_probability_max")]
        public int[] PrecipitationProbability { get; set; } = [];
    }
}