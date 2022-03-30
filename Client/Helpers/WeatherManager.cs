using Shared.Models;
using System.Text.Json;

namespace Client.Helpers
{
#nullable disable
  public class WeatherManager
  {
    public static async Task<WeatherModel> GetOpenWeatherAsync(string cityName)
    {
      var settingsFile = Path.GetFileName("settings.json");
      var apiDataSet = JsonSerializer.Deserialize<ConfigurationData[]>(File.ReadAllText(settingsFile));
      var locationUrl = $"{apiDataSet[0].Adresses.OpenweatherBase}geo/1.0/direct?q={cityName},ke&limit=1&appid={apiDataSet[0].ApiKeys.Openweather}";
      var defaultOptions = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
      using (HttpResponseMessage locationResponse = await API.UIProtocol.GetAsync(locationUrl))
      {
        try
        {
          var output= new WeatherModel { };
          locationResponse.EnsureSuccessStatusCode();
          var location = JsonSerializer.Deserialize<PositionData[]>(await locationResponse.Content.ReadAsStringAsync(), defaultOptions);
          if (location != null)
          {
            var forecastUrl = $"{apiDataSet[0].Adresses.OpenweatherBase}data/2.5/forecast?lat={location[0].lat}&lon={location[0].lon}&appid={apiDataSet[0].ApiKeys.Openweather}";

            var forecastResponse = await API.UIProtocol.GetAsync(forecastUrl);
            forecastResponse.EnsureSuccessStatusCode();
            if (forecastResponse.IsSuccessStatusCode)
            {
              output = JsonSerializer.Deserialize<WeatherModel>(await forecastResponse.Content.ReadAsStringAsync(), defaultOptions);
            }
          }
          return output;
        }
        catch (Exception ex)
        {
          throw new ApplicationException(ex.Message);
        }
      }
    }
  }
}
