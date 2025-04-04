using Maple.MonoGameAssistant.GameCore;
using Maple.MonoGameAssistant.GameShared;
using Maple.MonoGameAssistant.GameShared.Service;
using Maple.MonoGameAssistant.GameSSR;
using Maple.MonoGameAssistant.Model;
using Masa.Blazor;
using Masa.Blazor.Presets;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddMasaBlazor(p =>
{
    p.Defaults = new Dictionary<string, IDictionary<string, object?>?>()
    {
        [PopupComponents.SNACKBAR] = new Dictionary<string, object?>()
        {
            [nameof(PEnqueuedSnackbars.Closeable)] = true,
            [nameof(PEnqueuedSnackbars.Position)] = SnackPosition.TopCenter
        }
    };
    p.ConfigureTheme(theme =>
    {
        theme.Dark = true;
    });
});

builder.Services.AddHttpClient<GameHttpClientService>(p => p.BaseAddress = new Uri("http://localhost:18197/"))
    .ConfigurePrimaryHttpMessageHandler(p => new HttpClientHandler() { AutomaticDecompression = System.Net.DecompressionMethods.Brotli });



//builder.Services.AddNamedPipeHttpClientService(MonoJsonExtensions.GetPipeName(System.Diagnostics.Process.GetProcessesByName("Yaoling")[0]));
builder.Services.AddScoped<GameCoreService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(Main).Assembly);



app.Run();
