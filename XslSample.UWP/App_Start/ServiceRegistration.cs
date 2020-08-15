using XslSample.Documents;
using XslSample.Repositories;
using XslSample.UWP.Documents;
using XslSample.UWP.Repositories;

namespace XslSample.UWP.App_Start
{
    internal class ServiceRegistration
    {
        public static void Register(IServiceLocator locator)
        {
            locator.Register<IAssetRepository, AssetRepository>();
            locator.Register<IDocumentGenerator, DocumentGenerator>();
        }
    }
}
