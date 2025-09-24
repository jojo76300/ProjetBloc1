using Microsoft.Extensions.Logging;
using wwe.Pages;
using wwe.ViewModels;

namespace wwe;

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
            });

        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddSingleton<Accueil>();
        builder.Services.AddSingleton<Catcheur>();
        builder.Services.AddSingleton<Championnat>();
        builder.Services.AddSingleton<CatcheurViewModel>();
        builder.Services.AddSingleton<ChampionnatViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}