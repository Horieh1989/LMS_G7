using LMS_G7.Client;
using LMS_G7.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("LMS_G7.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("LMS_G7.ServerAPI"));

builder.Services.AddApiAuthorization();
builder.Services.AddSingleton<IUserDataService, UserDataService>();
builder.Services.AddSingleton<ICourseDataService, CourseDataService>();
builder.Services.AddSingleton<IModuleDataService, ModuleDataService>();

await builder.Build().RunAsync();
