using Microsoft.AspNetCore.Components.WebView.Maui;
using Hybrid.NativeClients.Data;
using Hybrid.Shared.Services;
using Hybrid.NativeClients.Services;

namespace Hybrid.NativeClients;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		
		builder.Services.AddSingleton<WeatherForecastService>();

		builder.Services.AddSingleton<IDataService, DataService>();
		builder.Services.AddSingleton<IGeoService, AppGeoService>();

		return builder.Build();
	}
}

