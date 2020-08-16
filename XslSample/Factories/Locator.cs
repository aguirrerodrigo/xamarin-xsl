using System;
using SimpleInjector;

namespace XslSample.Factories
{
    internal static class Locator
    {
        private static readonly Container container = new Container();

        public static void Register<T>() 
            where T : class
        {
            container.Register<T>(Lifestyle.Transient);
        }

        public static void RegisterService<TService, TImplementation>() 
            where TService : class
            where TImplementation : class, TService
        {
            container.Register<TService, TImplementation>(Lifestyle.Singleton);
        }

        public static void RegisterService<TService>(TService instance)
            where TService : class
        {
            container.Register<TService>(() => instance, Lifestyle.Singleton);
        }
        
        public static T GetInstance<T>() where T : class
        {
            return container.GetInstance<T>();
        }

        public static object GetInstance(Type type)
        {
            return container.GetInstance(type);
        }

        public static void Verify()
        {
            container.Verify();
        }
    }
}