using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Hybrid.Shared.Services;
using Hybrid.Web.Services;
using Darnton.Blazor.DeviceInterop.Geolocation;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseWebRoot("wwwroot").UseStaticWebAssets();


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<IDataService, DataService>();

builder.Services.AddScoped<IGeoService, WebGeoService>();

builder.Services
    .AddScoped<IGeolocationService, GeolocationService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

