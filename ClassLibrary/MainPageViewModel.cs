using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ClassLibrary
{
    public partial class MainPageViewModel : ObservableObject
    {
        private INavigationService _navigationService;

        [ObservableProperty]
        private string mainPageMessage;

        [ObservableProperty]
        private ObjectWeAreSending message;
        public MainPageViewModel(INavigationService navService)
        {
            MainPageMessage = "This is the main Page";
            Message = new ObjectWeAreSending();
            _navigationService = navService;

        }
        [RelayCommand]
        public async Task OpenNewPage()
        {
            await _navigationService.NavigateToAsync("OtherPage", Message);
        }
    }
}
