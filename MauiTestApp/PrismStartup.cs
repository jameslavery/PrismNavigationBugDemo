using MauiTestApp.UI.MainPage;
using MauiTestApp.UI.SecondPage;

namespace MauiTestApp;

/// <summary>
/// Controls the bootstrap process for the application.
/// </summary>
internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
            .OnAppStart("NavigationPage/MainPage");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        // Pages
        containerRegistry.RegisterForNavigation<MainPage>()
            .RegisterInstance(SemanticScreenReader.Default);

        containerRegistry.RegisterForNavigation<SecondPage>()
            .RegisterInstance(SemanticScreenReader.Default);
    }
}