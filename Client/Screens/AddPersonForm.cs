using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Screens
{
  public partial class AddPersonForm : BaseForm
  {
    private string _url = "https://localhost:7217/people";

    public AddPersonForm()
    {
      InitializeComponent();
    }

    private async void SaveButton_Click(object sender, EventArgs e)
    {
      using (HttpClient http = new HttpClient())
      {
        var person = new Person
        {
          FirstName = firstNameTextBox.Text.Trim(),
          LastName = lastNameTextBox.Text.Trim(),
          EmailAddress = emailAddressTextBox.Text.Trim()
        };
        var response = await http.PostAsJsonAsync(_url, person);
        if (response.IsSuccessStatusCode)
        {
          MessageBox.Show("Succeeded");
          firstNameTextBox.Clear(); lastNameTextBox.Clear(); emailAddressTextBox.Clear();
        }
      }
    }
  }
}
