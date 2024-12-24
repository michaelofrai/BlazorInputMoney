using BlazorInputMoney.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Add localization.
builder.Services.AddLocalization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}


app.UseAntiforgery();

app.MapStaticAssets();

// Add localization.
var cults = RaiCulture.AllCulturesNames();

app.UseRequestLocalization(new RequestLocalizationOptions()
    .AddSupportedCultures(cults)
    .AddSupportedUICultures(cults));

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
