using ForecastApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastApp.GeoService.Interfaces
{
    public interface IGeoService
    {
        public Task<CityModel> GetCoordinatesByCityNameAsync(string cityName);
    }
}
