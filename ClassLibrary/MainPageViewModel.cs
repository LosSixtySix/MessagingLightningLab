using CommunityToolkit.Mvvm.ComponentModel;

namespace ClassLibrary
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string mainPageMessage;
        public MainPageViewModel()
        {
            mainPageMessage = "This is the main Page";
        }
    }
}
