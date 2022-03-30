using System.Net.Http.Headers;

namespace Client.Helpers;

public static class API
{
#nullable disable
  public static HttpClient UIProtocol { get; set; }
  public static void InitializeProtocol()
  {
    UIProtocol = new HttpClient();
    UIProtocol.DefaultRequestHeaders.Accept.Clear();
    UIProtocol.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    UIProtocol.DefaultRequestHeaders.Add("api_key", "tPu12VeP5kubw9bG48KcG0NG4VHte3B1");
  }
}
