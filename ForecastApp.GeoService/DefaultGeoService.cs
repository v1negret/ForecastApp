using ForecastApp.GeoService.Interfaces;
using ForecastApp.Models;
using ForecastApp.Models.Enums;
using System.Text.Json;

namespace ForecastApp.GeoService
{
    public class DefaultGeoService : IGeoService
    {
        private HttpClient _httpClient = new HttpClient();
        private readonly string _apiKey;
        public DefaultGeoService(string apiKey)
        {
            _apiKey = apiKey;
        }

        /// <summary>
        /// Функция, получающая информацию о городе(широту, долготу) по его названию
        /// </summary>
        /// <param name="cityName">Название города</param>
        /// <returns>Объект с широтой и долготой, по которым находится город</returns>
        public async Task<CityModel> GetCoordinatesByCityNameAsync(string cityName)
        {

            var request = $"http://api.openweathermap.org/geo/1.0/direct?q={cityName}&limit=1&appid={_apiKey}";
            var response = (HttpResponseMessage)await _httpClient.GetAsync(request);
            if (response.IsSuccessStatusCode)
            {

                var content = await response.Content.ReadAsStringAsync();
                if (content == "[]")
                {
                    return new CityModel()
                    {
                        StatusCode = StatusCode.NotFound
                    };
                }
                var result = JsonSerializer.Deserialize<List<CityModel>>(content).First();
                return result;
            }
            else
            {
                return new CityModel()
                {
                    StatusCode = StatusCode.Unauthorized
                };
            }
        }
    }
}
