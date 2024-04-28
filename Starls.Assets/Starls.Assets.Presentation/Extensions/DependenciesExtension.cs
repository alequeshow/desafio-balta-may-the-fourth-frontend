using Starls.Assets.Service.Gateway.Interfaces;
using Starls.Assets.Service.Gateway;
using Starls.Assets.Service.Interfaces;
using Starls.Assets.Service;
using Starls.Assets.DTO.Configuration;

namespace Starls.Assets.Presentation.Extensions
{
    public static class DependenciesExtension
    {

        public static void AddGateways(this IServiceCollection services)
        {
            services.AddScoped<IFilmGateway, FilmGateway>();
            
            services.AddScoped<IVehicleGateway, VehicleGateway>();
            
            services.AddScoped<IPlanetGateway, PlanetGateway>();
            
            services.AddScoped<ICharacterGateway, CharacterGateway>();
            
            services.AddScoped<IStarshipGateway, StarshipGateway>();
        }


        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IFilmService, FilmService>();

            services.AddScoped<IVehicleService, VehicleService>();

            services.AddScoped<IPlanetService, PlanetService>();

            services.AddScoped<ICharacterService, CharacterService>();

            services.AddScoped<IStarshipService, StarshipService>();
        }

        public static void AddHttpClient(this IServiceCollection services, AppConfiguration configuration)
        {
            services.AddHttpClient(configuration.FilmProviderConfiguration.Name, client =>
            {
                client.BaseAddress = new Uri(configuration.FilmProviderConfiguration.Url);
            });

            services.AddHttpClient(configuration.VehicleProviderConfiguration.Name, client =>
            {
                client.BaseAddress = new Uri(configuration.VehicleProviderConfiguration.Url);
            });

            services.AddHttpClient(configuration.PlanetProviderConfiguration.Name, client =>
            {
                client.BaseAddress = new Uri(configuration.PlanetProviderConfiguration.Url);
            });

            services.AddHttpClient(configuration.CharacterProviderConfiguration.Name, client =>
            {
                client.BaseAddress = new Uri(configuration.CharacterProviderConfiguration.Url);
            });

            services.AddHttpClient(configuration.StarshipProviderConfiguration.Name, client =>
            {
                client.BaseAddress = new Uri(configuration.StarshipProviderConfiguration.Url);
            });
        }


    }
}
