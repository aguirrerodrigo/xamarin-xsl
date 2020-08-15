using XslSample.UWP.App_Start;

namespace XslSample.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            ServiceRegistration.Register(ServiceLocator.Instance);

            LoadApplication(new XslSample.App());
        }
    }
}
