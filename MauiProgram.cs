namespace Sirbu_Iulia_Lab7;

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
			})
		    .ConfigureEssentials(essentials =>
			{
             essentials.UseMapServiceToken("5XrNDULbC0yA8qEOhOtM~3jd4N_lFakjRff6HwijQSA~Airla684z1Is_YdQgXvNkeDJCwnEaivgWEuIpGeL1myPgcjEV_qMzxrYUzDd0-lI");
			 });

        return builder.Build();
	}
}
