using Client.Helpers;
using Shared.Models;
using System.Text.Json;

namespace Client.Screens
{
  public partial class MainForm
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void LoadDataButton_Click(object sender, EventArgs e)
    {
      var file = Path.GetFullPath("cities.txt");
      var lines = File.ReadAllLines(file);
      var cities = new List<string>();
      foreach (var line in lines)
      {
        cities.Add(line);
      }
      cities.Sort();
      new CityForm(cities).ShowDialog();
    }

    private async void LoadPeopleButton_Click(object sender, EventArgs e)
    {
      var _url = "https://localhost:7217/people";
      using (HttpClient httpClient = new HttpClient())
      {
        var response = await httpClient.GetAsync(_url);
        var responseContent = await response.Content.ReadAsStringAsync();
        var people = JsonSerializer.Deserialize<Person[]>(responseContent, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        if (people != null)
        {
          new PeopleForm(people).ShowDialog();
        }
        else
        {
          MessageBox.Show("error");
        }
      }
    }
  }
}
