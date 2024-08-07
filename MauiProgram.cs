using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Components.Authorization;
using Auth0.OidcClient;

namespace MauiBlazorAuth0App;

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
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton(new Auth0Client(new()
          {
            Domain = "<YOUR_AUTH0_DOMAIN>",
            ClientId = "<YOUR_CLIENT_ID>",
            Scope = "openid profile",
            RedirectUri = "myapp://callback/"
          }));
		builder.Services.AddAuthorizationCore();
		builder.Services.AddScoped<AuthenticationStateProvider, Auth0AuthenticationStateProvider>();
		
		return builder.Build();
	}
}
