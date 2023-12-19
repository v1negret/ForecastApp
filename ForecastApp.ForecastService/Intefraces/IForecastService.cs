using ForecastApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastApp.ForecastService.Intefraces
{
    public interface IForecastService
    {
        public Task<WeatherViewModel> GetCurrentWeatherAsync(string cityName);
    }
}
