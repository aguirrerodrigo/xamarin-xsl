using System.Threading.Tasks;
using XslSample.Documents;
using XslSample.Repositories;

namespace XslSample.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IAssetRepository assetRepository;
        private readonly IDocumentGenerator documentGenerator;

        public DocumentService(
            IAssetRepository assetRepository, 
            IDocumentGenerator documentGenerator)
        {
            this.assetRepository = assetRepository;
            this.documentGenerator = documentGenerator;
        }

        public async Task<string> GetAsync()
        {
            var xml = await assetRepository.GetTextAsync(@"Documents/cdcatalog.xml");
            var xsl = await assetRepository.GetTextAsync(@"Documents/cdcatalog.xsl");

            var doc = await documentGenerator.GenerateAsync(xml, xsl);
            return doc;
        }
    }
}
