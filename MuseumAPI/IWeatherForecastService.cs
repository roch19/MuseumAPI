using System.Collections.Generic;

namespace MuseumAPI
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get(int maxResultCount, int minTemperature, int maxTemperature);
    }
}