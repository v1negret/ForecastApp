using ForecastApp.ForecastService;
using ForecastApp.ForecastService.Intefraces;
using ForecastApp.GeoService;
using ForecastApp.GeoService.Interfaces;

namespace ForecastApp.View
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                var apiKey = File.ReadAllText("ApiKey.txt");
                var forecastService = new DefaultForecastService(apiKey);

                ApplicationConfiguration.Initialize();
                Application.Run(new MainForm(forecastService));

            }catch (Exception ex)
            {
                File.WriteAllText("Error.txt", ex.Message);
            }
        }
    }
}