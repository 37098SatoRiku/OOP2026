using System.Windows;
using WeatherApp.Services;

namespace WeatherApp;

public partial class MainWindow : Window {
    private readonly WeatherService _weatherService;

    public MainWindow() {
        InitializeComponent();
        _weatherService = new WeatherService();
        Loaded += MainWindow_Loaded;
    }

    private async void MainWindow_Loaded(object sender,RoutedEventArgs e) {
        var weather = await _weatherService.GetWeatherAsync();

        if(weather == null) {
            TemperatureText.Text ="取得失敗";
            return;
        }

        TemperatureText.Text =$"気温: {weather.Temperature} ℃";
        WeatherText.Text =$"天気コード: {weather.WeatherCode}";
        HumidityText.Text =$"湿度：{weather.Humidity} %";
        WindSpeedText.Text =$"風速：{weather.WindSpeed} km/h";
    }
}