using Xamarin.Forms;

namespace XslSample
{
    public interface IPageFactory
    {
        Page Create<TPage>() where TPage : class;
        void Register<TPage, TViewModel>()
            where TPage : class
            where TViewModel : class;
    }
}