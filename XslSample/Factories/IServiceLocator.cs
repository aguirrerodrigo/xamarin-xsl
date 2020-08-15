using System;

namespace XslSample
{
    public interface IServiceLocator
    {
        object GetInstance(Type type);
        T GetInstance<T>() where T : class;
        void Register<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;
    }
}