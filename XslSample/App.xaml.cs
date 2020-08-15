using Xamarin.Forms;
using XslSample.App_Start;
using XslSample.Factories;
using XslSample.Views;

namespace XslSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ServiceRegistration.Register(ServiceLocator.Instance);
            PageRegistration.Register(PageFactory.Instance);

            MainPage = PageFactory.Instance.Create<MainPage>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
