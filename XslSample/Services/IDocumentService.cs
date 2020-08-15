using System.Threading.Tasks;

namespace XslSample.Services
{
    public interface IDocumentService
    {
        Task<string> GetAsync();
    }
}
