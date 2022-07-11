using ClotheStore.Commons;
using ClotheStore.Services;
using ClotheStore.Services.Interfaces;
using ClotheStore.ViewModels.Home;
using ClotheStore.Views.Pages;
using CsharpTools.Services;
using CsharpTools.Services.Interfaces;
using Prism;
using Prism.Ioc;

namespace ClotheStore;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UsePrismApp<App>(prismAppBuilder =>
{
				prismAppBuilder.RegisterTypes(containerRegistry =>
				{
                    containerRegistry.RegisterForNavigation();
                    containerRegistry.RegisterServices();
                });
				prismAppBuilder.OnAppStart(async navigationService => await navigationService.NavigateAsync("HomePage"));

            })
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Icons.ttf", Constants.IconFont);
			});

		return builder.Build();
	}

	private static void RegisterForNavigation(this IContainerRegistry containerRegistry)
	{
		containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();

    }

    private static void RegisterServices(this IContainerRegistry containerRegistry)
    {
		containerRegistry.RegisterSingleton<IHttpService, HttpService>();
		containerRegistry.RegisterSingleton<IClotheService, FactoryClotheService>();
    }
}
