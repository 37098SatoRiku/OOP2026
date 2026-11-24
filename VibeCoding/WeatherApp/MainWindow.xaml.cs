using System.Windows;
using WeatherApp.Services;
using WeatherApp.Models;

namespace WeatherApp;

public partial class MainWindow : Window {
    private readonly WeatherService _weatherService;

    public MainWindow() {
        InitializeComponent();
        _weatherService = new WeatherService();
        CityComboBox.ItemsSource = _cities;
        CityComboBox.DisplayMemberPath = "Name";
        CityComboBox.SelectedIndex = 0;
        Loaded += MainWindow_Loaded;
    }

    private readonly List<CityInfo> _cities =
[
    new() { Name = "北海道", Latitude = 43.0642, Longitude = 141.3469 },
    new() { Name = "青森県", Latitude = 40.8244, Longitude = 140.7400 },
    new() { Name = "岩手県", Latitude = 39.7036, Longitude = 141.1527 },
    new() { Name = "宮城県", Latitude = 38.2682, Longitude = 140.8694 },
    new() { Name = "秋田県", Latitude = 39.7186, Longitude = 140.1024 },
    new() { Name = "山形県", Latitude = 38.2404, Longitude = 140.3633 },
    new() { Name = "福島県", Latitude = 37.7503, Longitude = 140.4676 },
    new() { Name = "茨城県", Latitude = 36.3418, Longitude = 140.4468 },
    new() { Name = "栃木県", Latitude = 36.5658, Longitude = 139.8836 },
    new() { Name = "群馬県", Latitude = 36.3912, Longitude = 139.0609 },
    new() { Name = "埼玉県", Latitude = 35.8569, Longitude = 139.6489 },
    new() { Name = "千葉県", Latitude = 35.6047, Longitude = 140.1233 },
    new() { Name = "東京都", Latitude = 35.6895, Longitude = 139.6917 },
    new() { Name = "神奈川県", Latitude = 35.4478, Longitude = 139.6425 },
    new() { Name = "新潟県", Latitude = 37.9026, Longitude = 139.0236 },
    new() { Name = "富山県", Latitude = 36.6953, Longitude = 137.2113 },
    new() { Name = "石川県", Latitude = 36.5944, Longitude = 136.6256 },
    new() { Name = "福井県", Latitude = 36.0652, Longitude = 136.2216 },
    new() { Name = "山梨県", Latitude = 35.6642, Longitude = 138.5684 },
    new() { Name = "長野県", Latitude = 36.6513, Longitude = 138.1810 },
    new() { Name = "岐阜県", Latitude = 35.3912, Longitude = 136.7222 },
    new() { Name = "静岡県", Latitude = 34.9769, Longitude = 138.3831 },
    new() { Name = "愛知県", Latitude = 35.1802, Longitude = 136.9066 },
    new() { Name = "三重県", Latitude = 34.7303, Longitude = 136.5086 },
    new() { Name = "滋賀県", Latitude = 35.0045, Longitude = 135.8686 },
    new() { Name = "京都府", Latitude = 35.0214, Longitude = 135.7556 },
    new() { Name = "大阪府", Latitude = 34.6937, Longitude = 135.5023 },
    new() { Name = "兵庫県", Latitude = 34.6913, Longitude = 135.1830 },
    new() { Name = "奈良県", Latitude = 34.6851, Longitude = 135.8048 },
    new() { Name = "和歌山県", Latitude = 34.2260, Longitude = 135.1675 },
    new() { Name = "鳥取県", Latitude = 35.5039, Longitude = 134.2377 },
    new() { Name = "島根県", Latitude = 35.4723, Longitude = 133.0505 },
    new() { Name = "岡山県", Latitude = 34.6618, Longitude = 133.9350 },
    new() { Name = "広島県", Latitude = 34.3963, Longitude = 132.4596 },
    new() { Name = "山口県", Latitude = 34.1858, Longitude = 131.4714 },
    new() { Name = "徳島県", Latitude = 34.0658, Longitude = 134.5593 },
    new() { Name = "香川県", Latitude = 34.3401, Longitude = 134.0434 },
    new() { Name = "愛媛県", Latitude = 33.8416, Longitude = 132.7657 },
    new() { Name = "高知県", Latitude = 33.5597, Longitude = 133.5311 },
    new() { Name = "福岡県", Latitude = 33.5902, Longitude = 130.4017 },
    new() { Name = "佐賀県", Latitude = 33.2494, Longitude = 130.2988 },
    new() { Name = "長崎県", Latitude = 32.7448, Longitude = 129.8737 },
    new() { Name = "熊本県", Latitude = 32.8031, Longitude = 130.7079 },
    new() { Name = "大分県", Latitude = 33.2382, Longitude = 131.6126 },
    new() { Name = "宮崎県", Latitude = 31.9111, Longitude = 131.4239 },
    new() { Name = "鹿児島県", Latitude = 31.5602, Longitude = 130.5581 },
    new() { Name = "沖縄県", Latitude = 26.2124, Longitude = 127.6809 }
];

    private async void MainWindow_Loaded(object sender, RoutedEventArgs e) {
        await LoadWeatherAsync();
    }

    private string GetWeatherIcon(int code) {
        return code switch {
            0 => "☀",
            1 => "🌤",
            2 => "⛅",
            3 => "☁",
            61 => "🌧",
            63 => "🌧",
            65 => "🌧",
            71 => "❄",
            73 => "❄",
            75 => "❄",
            95 => "⛈",
            _ => "🌈"
        };
    }

    private async Task LoadWeatherAsync() {
        TemperatureText.Text = "取得中...";
        WeatherText.Text = "";
        HumidityText.Text = "";
        WindSpeedText.Text = "";
        ErrorText.Text = "";

        CityInfo city = (CityInfo)CityComboBox.SelectedItem;

        var weather = await _weatherService.GetWeatherAsync(city.Latitude, city.Longitude);

        if(weather == null) {
            ErrorText.Text =
                _weatherService.ErrorMessage;

            return;
        }

        TemperatureText.Text = $"{weather.Temperature}°";
        WeatherText.Text = $"{GetWeatherIcon(weather.WeatherCode)} {weather.WeatherDescription}";
        HumidityText.Text = $"湿度：{weather.Humidity}%";
        WindSpeedText.Text = $"風速：{weather.WindSpeed} km/h";
        CityText.Text = city.Name;

        ForecastListBox.Items.Clear();

        foreach(var forecast in weather.DailyForecasts) {
            ForecastListBox.Items.Add(
                $"{forecast.Date:yyyy/MM/dd}   " +
                $"{GetWeatherIcon(forecast.WeatherCode)} " +
                $"{forecast.WeatherDescription}   " +
                $"{forecast.MinTemperature:F0}° / {forecast.MaxTemperature:F0}°   " +
                $"☔{forecast.PrecipitationProbability}%");
        }
    }

    private async void UpdateButton_Click(object sender, RoutedEventArgs e) {
        await LoadWeatherAsync();
    }


}