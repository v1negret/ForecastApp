using ForecastApp.ForecastService.Intefraces;
using ForecastApp.GeoService;
using ForecastApp.GeoService.Interfaces;
using ForecastApp.Models.Enums;
using ForecastApp.Models.ViewModels;
using System.Text.Json;

namespace ForecastApp.ForecastService
{
    public class DefaultForecastService : IForecastService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly string _apiKey;
        private readonly IGeoService _geoService;

        public DefaultForecastService(string apiKey)
        {
            _apiKey = apiKey;
            _geoService = new DefaultGeoService(_apiKey);
        }

        /// <summary>
        /// Получает информацию о погоде в указанном городе в данное время
        /// </summary>
        /// <param name="cityName">Название города</param>
        /// <returns>Объект, содержащий информацию о погоде в городе</returns>
        public async Task<WeatherViewModel> GetCurrentWeatherAsync(string cityName)
        {
            var cityData = await _geoService.GetCoordinatesByCityNameAsync(cityName);
            if(cityData.StatusCode == StatusCode.NotFound)
            {
                return new WeatherViewModel()
                {
                    StatusCode = StatusCode.NotFound
                };
            }
            if (cityData.StatusCode == StatusCode.Unauthorized)
            {
                return new WeatherViewModel()
                {
                    StatusCode = StatusCode.Unauthorized
                };
            }
            var request =
                $"https://api.openweathermap.org/data/2.5/weather?lat={cityData.Latitude}&lon={cityData.Lontitude}&units=metric&lang=ru&appid={_apiKey}";

            var response = await _httpClient.GetAsync(request);
            var content = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<WeatherViewModel>(content);

            return result;
        }
    }
}
