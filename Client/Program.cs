using Client.Helpers;
using Client.Screens;

namespace Client;

public static class Program
{
  /// <summary>
  ///  The main entry point for the application.
  /// </summary>
  [STAThread]
  static void Main()
  {
    // To customize application configuration such as set high DPI settings or default font,
    // see https://aka.ms/applicationconfiguration.
    ApplicationConfiguration.Initialize();
    API.InitializeProtocol();
    Application.Run(new MainForm());
  }
}
