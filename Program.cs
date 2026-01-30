using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MiPruebaBlazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

                                                        //Aqui se cambia la URL base del HttpClient
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri( "https://mainserver.ziursoftware.com/") });

await builder.Build().RunAsync();
