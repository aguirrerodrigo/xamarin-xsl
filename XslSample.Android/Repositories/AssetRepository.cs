using System;
using System.IO;
using System.Threading.Tasks;
using Android.App;
using XslSample.Repositories;

namespace XslSample.Droid.Repositories
{
    public class AssetRepository : IAssetRepository
    {
        public Task<string> GetTextAsync(string path)
        {
            path = path.Replace(@"\", @"/");

            return Task.Run(() =>
            {
                using (var stream = Application.Context.Assets.Open(path))
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            });
        }
    }
}