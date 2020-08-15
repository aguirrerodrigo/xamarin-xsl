using System;

namespace XslSample
{
    public class ServiceLocator : IServiceLocator
    {
        public static ServiceLocator Instance { get; } = new ServiceLocator();

        private ServiceLocator() 
        {
            Locator.RegisterService<IServiceLocator>(this);
        }

        public void Register<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService
        {
            Locator.RegisterService<TService, TImplementation>();
        }

        public T GetInstance<T>() where T : class
        {
            return Locator.GetInstance<T>();
        }

        public object GetInstance(Type type)
        {
            return Locator.GetInstance(type);
        }
    }
}