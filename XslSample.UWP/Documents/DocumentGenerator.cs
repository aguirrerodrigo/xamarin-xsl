using System.Threading.Tasks;
using Windows.Data.Xml.Dom;
using Windows.Data.Xml.Xsl;
using XslSample.Documents;

namespace XslSample.UWP.Documents
{
    public class DocumentGenerator : IDocumentGenerator
    {
        public Task<string> GenerateAsync(string xml, string xsl)
        {
            return Task.Run(() =>
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xml);

                var xslDoc = new XmlDocument();
                xslDoc.LoadXml(xsl);

                var processer = new XsltProcessor(xslDoc);
                return processer.TransformToString(xmlDoc);
            });
        }
    }
}
