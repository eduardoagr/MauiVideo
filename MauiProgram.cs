global using CommunityToolkit.Maui;
global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;

global using MauiVideo.Models;
global using MauiVideo.Services;
global using MauiVideo.ViewModels;
global using MauiVideo.Views;

global using Microsoft.Extensions.Logging;

global using System.Collections.ObjectModel;

namespace MauiVideo;
public static class MauiProgram {
    public static MauiApp CreateMauiApp() {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts => {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddSingleton<MainPage, MainPageViewModel>();
        builder.Services.AddTransient<DetailPage, DetailPageViewModel>();

        builder.Services.AddSingleton<HttpClient>();

        builder.Services.AddSingleton<HttpService>();
        builder.Services.AddSingleton(Connectivity.Current);


        return builder.Build();
    }
}
