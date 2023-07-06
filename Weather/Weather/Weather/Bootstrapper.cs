using Autofac;
using Weather.Services;
using Weather.ViewModels;
using Weather.Views;
using Xamarin.Forms;


namespace Weather
{
    public class Bootstrapper
    {
        public static void Init()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType

            <OpenWeatherMapWeatherService>().As <IWeatherService>();

            containerBuilder.RegisterType<MainViewModel>();

            var container = containerBuilder.Build();

            Resolver.Initialize(container);
        }
    }
}


