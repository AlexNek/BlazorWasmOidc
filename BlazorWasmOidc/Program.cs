using BlazorWasmOidc;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorWasmOidc
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddOidcAuthentication(options =>
            {
                //builder.Configuration.Bind("Keycloak", options.ProviderOptions);
                builder.Configuration.Bind("Auth0", options.ProviderOptions);
                // sample for code using
                //options.ProviderOptions.ResponseType = "code";
                //options.ProviderOptions.DefaultScopes.Add("address");
            });

            await builder.Build().RunAsync();
        }
    }
}