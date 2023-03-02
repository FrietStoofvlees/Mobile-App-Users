using Users.Services;
using Users.ViewModels;

namespace Users;

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

        builder.Services.AddSingleton<IUserService, UserService>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<UsersViewModel>();

        return builder.Build();
	}
}
