using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using SurveyBlazor.Web; // Namespace of your Blazor app

// Create a WebAssembly host builder using the default configuration
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add the root App component to the DOM element with id "app"
builder.RootComponents.Add<App>("#app");

// Add the HeadOutlet component to manage the contents of the <head> element
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configure HttpClient to point to the API base address
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5045/") });

// Build and run the Blazor WebAssembly app
await builder.Build().RunAsync();