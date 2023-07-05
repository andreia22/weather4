using System.Threading.Tasks;
using Weather.Models;


namespace Weather.Services
{
    public interface IWeatherService
    {
        Task<Forecast> GetForecast(double latitude, double longitude);
    }

    /*public async Task LoadData()
    { 

         var location = await Geolocation.GetLocationAsync();
         var forecast = await weatherService.GetForecast
            (location.Latitude, location.Longitude);
        {
            var itemGroups = new List<ForecastGroup>();
            foreach (var item in forecast.Items)
            {
                if (!itemGroups.Any())
                {
                    itemGroups.Add(new ForecastGroup(
                    new List<ForecastItem>() { item })
                    { Date = item.DateTime.Date });
                    continue;
                }
                var group = itemGroups.SingleOrDefault(x => x.Date ==
                item.DateTime.Date);
                if (group == null)
                {
                    itemGroups.Add(new ForecastGroup(
                    new List<ForecastItem>() { item })
                    { Date = item.DateTime.Date });
                    continue;
                }
                group.Items.Add(item);
            }
            Days = new ObservableCollection<ForecastGroup>(itemGroups);
            City = forecast.City;
        }
    }
    */

}




