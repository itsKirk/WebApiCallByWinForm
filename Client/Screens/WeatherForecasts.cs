using Shared.Models;

namespace Client.Screens
{
  public partial class WeatherForecasts : BaseForm
  {
    private readonly WeatherModel _weatherForecasts;

    public WeatherForecasts(WeatherModel weatherForecasts, string selectedCity)
    {
      InitializeComponent();

      _weatherForecasts = weatherForecasts;
      labelText.Text = $"{selectedCity} Weather Forecast";
    }

    private void WeatherForecasts_Load(object sender, EventArgs e)
    {

      var weather = new List<Weather>();
      foreach (var list in _weatherForecasts.list)
      {
        weather.AddRange(list.weather);
      }
      forecastsDgv.DataSource = weather;
    }
  }
}
