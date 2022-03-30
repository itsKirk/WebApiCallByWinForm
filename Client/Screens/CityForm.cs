using Client.Helpers;

namespace Client.Screens
{
  public partial class CityForm : Form
  {
    public CityForm(List<string> cities)
    {
      InitializeComponent();
      foreach (var city in cities)
      {
        CitiesComboBox.Items.Add(city);
      }
    }
    private async Task LoadWeather(string city)
    {
      var data = await WeatherManager.GetOpenWeatherAsync(city);
      if (data != null)
      {
        new WeatherForecasts(data, city).ShowDialog();
      }
      else
      {
        MessageBox.Show("error");
      }
    }
#nullable disable
    private async void CityButton_Click(object sender, EventArgs e)
    {
      if (CitiesComboBox.SelectedIndex != -1)
      {
        await LoadWeather(CitiesComboBox.SelectedItem.ToString());
      }
    }
  }
}
