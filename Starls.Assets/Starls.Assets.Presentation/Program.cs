using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Starls.Assets.DTO.Configuration;
using Starls.Assets.Presentation;
using Starls.Assets.Service;
using Starls.Assets.Service.Gateway;
using Starls.Assets.Service.Gateway.Interfaces;
using Starls.Assets.Service.Interfaces;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var configuration = builder.Configuration.Get<AppConfiguration>() ?? new();

builder.Services.AddSingleton(configuration);

// Setup client instances for each endpoint provider individually

builder.Services.AddHttpClient(configuration.FilmProviderConfiguration.Name, client =>
{
    client.BaseAddress = new Uri(configuration.FilmProviderConfiguration.Url);
});

builder.Services.AddHttpClient(configuration.VehicleProviderConfiguration.Name, client =>
{
    client.BaseAddress = new Uri(configuration.VehicleProviderConfiguration.Url);
});

builder.Services.AddHttpClient(configuration.PlanetProviderConfiguration.Name, client =>
{
    client.BaseAddress = new Uri(configuration.PlanetProviderConfiguration.Url);
});

builder.Services.AddHttpClient(configuration.CharacterProviderConfiguration.Name, client =>
{
    client.BaseAddress = new Uri(configuration.CharacterProviderConfiguration.Url);
});

builder.Services.AddHttpClient(configuration.StarshipProviderConfiguration.Name, client =>
{
    client.BaseAddress = new Uri(configuration.StarshipProviderConfiguration.Url);
});


//Setup gateway dependencies

builder.Services.AddScoped<IFilmGateway, FilmGateway>();

builder.Services.AddScoped<IVehicleGateway, VehicleGateway>();

builder.Services.AddScoped<IPlanetGateway, PlanetGateway>();

builder.Services.AddScoped<ICharacterGateway, CharacterGateway>();

builder.Services.AddScoped<IStarshipGateway, StarshipGateway>();

//Setup services dependencies

builder.Services.AddScoped<IFilmService, FilmService>();

builder.Services.AddScoped<IVehicleService, VehicleService>();

builder.Services.AddScoped<IPlanetService, PlanetService>();

builder.Services.AddScoped<ICharacterService, CharacterService>();

builder.Services.AddScoped<IStarshipService, StarshipService>();



await builder.Build().RunAsync();