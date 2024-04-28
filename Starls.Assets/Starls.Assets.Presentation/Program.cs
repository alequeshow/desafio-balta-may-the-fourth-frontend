using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Starls.Assets.DTO.Configuration;
using Starls.Assets.Presentation;
using Starls.Assets.Presentation.Extensions;
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
builder.Services.AddHttpClient(configuration);

//Setup gateway dependencies
builder.Services.AddGateways();

//Setup services dependencies

builder.Services.AddServices();



await builder.Build().RunAsync();