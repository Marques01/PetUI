using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PetServices.Authorization;
using PetUI;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient();

builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<AuthenticationStateProvider, AuthorizationStateProvider>();

//builder.Services.AddHttpClient<IProductServices, ProductServices>(x =>
//{
//    x.BaseAddress = new Uri("https://localhost:7117/");
//    x.DefaultRequestHeaders.Add("Accept", "application/+json");
//});

await builder.Build().RunAsync();
