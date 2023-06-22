using BlazorApp1.Client;
using BlazorApp1.Client.features.addForm;
using BlazorApp1.Client.features.addForm.data.services.FormService;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<viewModel>();
builder.Services.AddScoped<IFormService, FormService>();

await builder.Build().RunAsync();
