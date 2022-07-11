using ClotheStore.Commons;
using ClotheStore.ViewModels.Home;
using ClotheStore.Views.Pages;
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
					RegisterForNavigation(containerRegistry);

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

	private static void RegisterForNavigation(IContainerRegistry containerRegistry)
	{
		containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();

    }
}
