
using System.Diagnostics;

namespace MauiTestApp.UI.SecondPage;

public class SecondPageViewModel : BaseViewModel, INavigatedAware
{
    public DelegateCommand BackCommand { get; set; }

    public SecondPageViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        BackCommand = new DelegateCommand(Back);

    }

    private void Back()
    {
        _navigationService.GoBackAsync();
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
        Debug.WriteLine("Arrived at page 2");
    }

    private readonly INavigationService _navigationService;
}
