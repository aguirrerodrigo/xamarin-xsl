using System.Threading.Tasks;

namespace XslSample.Repositories
{
    public interface IAssetRepository
    {
        Task<string> GetTextAsync(string path);
    }
}
