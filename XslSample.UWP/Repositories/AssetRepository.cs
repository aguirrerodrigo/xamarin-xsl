using System;
using System.IO;
using System.Threading.Tasks;
using XslSample.Repositories;

namespace XslSample.UWP.Repositories
{
    public class AssetRepository : IAssetRepository
    {
        public async Task<string> GetTextAsync(string path)
        {
            path = path.Replace(@"/", @"\");

            var loc = Windows.ApplicationModel.Package.Current.InstalledLocation;
            var file = await loc.GetFileAsync(@"Assets\" + path);
            if (File.Exists(file.Path))
            {
                return File.ReadAllText(file.Path);
            }

            return null;
        }
    }
}
