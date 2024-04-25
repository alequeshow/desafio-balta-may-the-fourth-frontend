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

// Add HttpClient instances for each endpoint
builder.Services.AddHttpClient(configuration.FilmProviderConfiguration.Name, client =>
{
    client.BaseAddress = new Uri(configuration.FilmProviderConfiguration.Url);
});

builder.Services.AddHttpClient("SwApi.Characters", client =>
{
    client.BaseAddress = new Uri("http://localhost:1080");
});

builder.Services.AddHttpClient(configuration.VehicleProviderConfiguration.Name, client =>
{
    client.BaseAddress = new Uri(configuration.VehicleProviderConfiguration.Url);
});

builder.Services.AddHttpClient(configuration.PlanetProviderConfiguration.Name, client =>
{
    client.BaseAddress = new Uri(configuration.PlanetProviderConfiguration.Url);
});

builder.Services.AddHttpClient("SwApi.Starships", client =>
{
    client.BaseAddress = new Uri("http://localhost:1080");
});


builder.Services.AddScoped<IFilmGateway, FilmGateway>();

builder.Services.AddScoped<IVehicleGateway, VehicleGateway>();

builder.Services.AddScoped<IFilmService, FilmService>();

builder.Services.AddScoped<IVehicleService, VehicleService>();

builder.Services.AddScoped<IPlanetGateway, PlanetGateway>();



await builder.Build().RunAsync();