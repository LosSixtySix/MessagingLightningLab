using ClassLibrary;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

public partial class ObjectWeAreSending : ObservableObject
{
    [ObservableProperty]
    private string aCoolMessage;

    public ObjectWeAreSending()
    {
        aCoolMessage = "This is a pretty cool message";

    }


}