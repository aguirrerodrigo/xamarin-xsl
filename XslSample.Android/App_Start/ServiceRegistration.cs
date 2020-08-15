using XslSample.Documents;
using XslSample.Droid.Documents;
using XslSample.Droid.Repositories;
using XslSample.Factories;
using XslSample.Repositories;

namespace XslSample.Droid.App_Start
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