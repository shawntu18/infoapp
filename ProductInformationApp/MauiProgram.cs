using BarcodeScanning;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ProductInformationApp.ViewModels;
using ProductInformationApp.Views;
using UraniumUI;

namespace ProductInformationApp {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseUraniumUI()
                .UseMauiCommunityToolkit()
#if ANDROID
                .UseBarcodeScanning()
#endif
                .UseUraniumUIMaterial()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddMaterialIconFonts();
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<HttpClient>();
            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<ProductPage>();
            return builder.Build();
        }
    }
}
