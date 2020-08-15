using XslSample.Factories;
using XslSample.ViewModels;
using XslSample.Views;

namespace XslSample.App_Start
{
    internal class PageRegistration
    {
        public static void Register(IPageFactory factory)
        {
            factory.Register<MainPage, MainPageViewModel>();
        }
    }
}