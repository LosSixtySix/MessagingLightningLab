using CommunityToolkit.Mvvm.ComponentModel;

public partial class ObjectWeAreSending : ObservableObject
{
    [ObservableProperty]
    private string aCoolMessage;

    public ObjectWeAreSending()
    {
        aCoolMessage = "This is a pretty cool message";
    }
}