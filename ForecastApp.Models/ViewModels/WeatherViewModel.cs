using ForecastApp.Models.Enums;
using System.Text.Json.Serialization;

namespace ForecastApp.Models.ViewModels
{
    /// <summary>
    /// Содержит информацию о погоде в городе
    /// </summary>
    public class WeatherViewModel
    {
        [JsonPropertyName("weather")]
        public WeatherInfo[] Weather { get; set; }

        [JsonPropertyName("main")]
        public MainInfo Main { get; set; }

        [JsonPropertyName("wind")]
        public WindInfo Wind { get; set; }
        public StatusCode StatusCode { get; set; } = StatusCode.Ok;


        public class MainInfo
        {
            [JsonPropertyName("temp")]
            public float Temperature { get; set; }

        }

        public class WindInfo
        {
            [JsonPropertyName("speed")]
            public float Speed { get; set; }

        }

        public class WeatherInfo
        {
            [JsonPropertyName("description")]
            public string Description { get; set; }
        }

    }



}
