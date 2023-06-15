using Lossless.Domain.Auth0;

namespace Lossless;

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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("UberMoveBold.otf", "UberBold");
                fonts.AddFont("UberMoveMedium.otf", "UberMedium");
            });

        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddSingleton(new Auth0Client(new()
        {
            Domain = "slitenprodlossless.eu.auth0.com",
            ClientId = "PbAJH60ZZBvdlakaeYZTwjekClHnuFC2",
            Scope = "openid profile",
            RedirectUri = "myapp://callback"
        }));

        return builder.Build();
    }
}

