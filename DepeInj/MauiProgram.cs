using Microsoft.Extensions.Logging;
using DepeInj.View;
using DepeInj.ViewModel;
using Microsoft.Extensions.DependencyInjection;

namespace DepeInj;

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

		//builder.Services.AddSingleton<MainPage>();
       // builder.Services.AddSingleton<MainPageViewModel>();
       // builder.Services.AddSingleton<PersonDisplay>();
        //builder.Services.AddSingleton<PersonViewModel>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

