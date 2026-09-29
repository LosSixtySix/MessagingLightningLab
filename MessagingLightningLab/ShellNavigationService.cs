using ClassLibrary;
using CommunityToolkit.Mvvm.Messaging;

public class ShellNavigationService : INavigationService
{
    public async Task GoBackAsync()
    {
        await Shell.Current.GoToAsync("..");
    }

    public async Task NavigateToAsync(string route)
    {
        await Shell.Current.GoToAsync(route);
    }

    public async Task NavigateToAsync(string route, ObjectWeAreSending thing)
    {
        await Shell.Current.GoToAsync(route);
        WeakReferenceMessenger.Default.Send(new MessageEnvelope(thing));
    }
}