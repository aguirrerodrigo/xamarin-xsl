using XslSample.Services;

namespace XslSample.App_Start
{
    internal class ServiceRegistration
    {
        public static void Register(IServiceLocator locator)
        {
            locator.Register<IDocumentService, DocumentService>();
        }
    }
}