using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Telerik.Maui.Controls.Compatibility;
using TelerikMauiApp.ViewModels;

namespace TelerikMauiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseTelerik()
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<ComboViewModel>();

            builder.Services.AddTransient<ComboPage>();

            return builder.Build();
        }
    }
}
