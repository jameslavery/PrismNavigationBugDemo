namespace MauiTestApp.UI.MainPage;

public class MainPageViewModel : BindableBase
{
    private readonly INavigationService _navigationService;

    public DelegateCommand SecondPageNotAnimatedModalCommand { get; set; }
    public DelegateCommand SecondPageNotAnimatedNonModalCommand { get; set; }
    public DelegateCommand SecondPageAnimatedModalCommand { get; set; }
    public DelegateCommand SecondPageAnimatedNonModalCommand { get; set; }

    public MainPageViewModel(
        INavigationService navigationService)
    {
        _navigationService = navigationService;
        SecondPageNotAnimatedModalCommand = new DelegateCommand(SecondPageNotAnimatedModal);
        SecondPageNotAnimatedNonModalCommand = new DelegateCommand(SecondPageNotAnimatedNonModal);
        SecondPageAnimatedModalCommand = new DelegateCommand(SecondPageAnimatedModal);
        SecondPageAnimatedNonModalCommand = new DelegateCommand(SecondPageAnimatedNonModal);

    }

    private void SecondPageNotAnimatedModal()
    {
        var navParams = new NavigationParameters()
        {
            {KnownNavigationParameters.Animated,false},
            {KnownNavigationParameters.UseModalNavigation, true },
        };

        _navigationService.NavigateAsync(nameof(SecondPage), navParams);
    }

    private void SecondPageNotAnimatedNonModal()
    {
        var navParams = new NavigationParameters()
        {
            {KnownNavigationParameters.Animated,false},
            {KnownNavigationParameters.UseModalNavigation, false },
        };

        _navigationService.NavigateAsync(nameof(SecondPage), navParams);
    }

    private void SecondPageAnimatedModal()
    {
        var navParams = new NavigationParameters()
        {
            {KnownNavigationParameters.Animated,true},
            {KnownNavigationParameters.UseModalNavigation, true },
        };

        _navigationService.NavigateAsync(nameof(SecondPage), navParams);
    }

    private void SecondPageAnimatedNonModal()
    {
        var navParams = new NavigationParameters()
        {
            {KnownNavigationParameters.Animated,true},
            {KnownNavigationParameters.UseModalNavigation, false },
        };

        _navigationService.NavigateAsync(nameof(SecondPage), navParams);
    }
}