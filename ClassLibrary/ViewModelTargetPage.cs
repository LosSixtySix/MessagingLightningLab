using ClassLibrary;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

public partial class ViewModelTargetPage : ObservableObject
{
    [ObservableProperty]
    private ObjectWeAreSending? thing;
    public ViewModelTargetPage()
    {
    }

}
