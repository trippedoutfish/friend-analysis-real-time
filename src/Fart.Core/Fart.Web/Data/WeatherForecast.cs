using System;

namespace Fart.Web.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF { get; set; }

        public string Summary { get; set; }

        public WeatherForecast()
        {

        }
        public WeatherForecast(DateTime Date, int TemperatureC, string Summary)
        {
            this.Date = Date;
            this.TemperatureC = TemperatureC;
            this.TemperatureF = (TemperatureC * 9 / 5) + 32;
            this.Summary = Summary;
        }
    }
}
