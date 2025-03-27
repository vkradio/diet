using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using VkRadio.Diet.Blazor;
using VkRadio.Diet.Blazor.Services;
using VkRadio.Diet.Core;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder
    .Services
    .AddTransient<IMenuService, MenuService>()
    .AddTransient<IOrderService, OrderService>();

await builder.Build().RunAsync();
