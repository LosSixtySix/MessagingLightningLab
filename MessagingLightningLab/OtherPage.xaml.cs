namespace MessagingLightningLab;

public partial class OtherPage : ContentPage
{
	public OtherPage(ViewModelTargetPage viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}