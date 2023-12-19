using ForecastApp.Models.Enums;
using System.Text.Json.Serialization;

namespace ForecastApp.Models
{
    /// <summary>
    /// Содержит информацию о широте и долготе, по которым находится город, а также свойство для хранения статус кода.
    /// </summary>
    public class CityModel
    {

        [JsonPropertyName("lat")]
        public float Latitude { get; set; }

        [JsonPropertyName("lon")]
        public float Lontitude { get; set; }
        public StatusCode StatusCode { get; set; } = StatusCode.Ok;
    }
}
