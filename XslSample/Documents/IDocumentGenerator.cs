using System.Threading.Tasks;

namespace XslSample.Documents
{
    public interface IDocumentGenerator
    {
        Task<string> GenerateAsync(string xml, string xsl);
    }
}
