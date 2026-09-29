namespace MessagingLightningLab
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("OtherPage", typeof(OtherPage));
        }
    }
}
