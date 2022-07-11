using ReactiveUI;
using Sharpnado.Tasks;

namespace ClotheStore.ViewModels;

public class BaseViewModel : ReactiveObject, INavigatedAware, IInitializeAsync
{
    protected INavigationService NavigationService;
    public BaseViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }

    public async Task InitializeAsync(INavigationParameters parameters)
    {
    }

    public void OnNavigatedTo(INavigationParameters parameters)
    {
        TaskMonitor.Create(OnNavigatedToAsync(parameters),
                           whenFaulted: t =>
                           {
                               t.Exception.Handle(ex =>
                               {
                                   return true;
                               });
                           });


        //DeactivateWith.Add(Activator.Activate());
    }

    public void OnNavigatedFrom(INavigationParameters parameters)
    {
        TaskMonitor.Create(OnNavigatedFromAsync(parameters),
                           whenFaulted: t =>
                           {
                               t.Exception.Handle(ex =>
                               {
                                   return true;
                               });
                           });
    }

    protected virtual Task OnNavigatedToAsync(INavigationParameters parameters)
    {
        return Task.FromResult(0);
    }

    protected virtual Task OnNavigatedFromAsync(INavigationParameters parameters)
    {
        return Task.FromResult(0);
    }
}