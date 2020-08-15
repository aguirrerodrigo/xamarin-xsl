using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XslSample.Factories
{
    public class PageFactory : IPageFactory
    {
        public static PageFactory Instance { get; } = new PageFactory();

        private Dictionary<Type, Type> mapping = new Dictionary<Type, Type>();

        private PageFactory() 
        {
            Locator.RegisterService<IPageFactory>(this);
        }

        public void Register<TPage, TViewModel>()
            where TPage : class
            where TViewModel : class
        {
            Locator.Register<TPage>();
            Locator.Register<TViewModel>();

            mapping.Add(typeof(TPage), typeof(TViewModel));
        }

        public Page Create<TPage>() where TPage : class
        {
            var page = Locator.GetInstance<TPage>() as Page;
            if (page != null && mapping.ContainsKey(typeof(TPage)))
            {
                var viewModelType = mapping[typeof(TPage)];
                page.BindingContext = Locator.GetInstance(viewModelType);
            }

            return page;
        }
    }
}
