using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastApp.Models.Enums
{
    public enum StatusCode
    {
        Ok = 200,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
    }
}
