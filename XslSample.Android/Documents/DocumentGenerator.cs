using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;
using XslSample.Documents;

namespace XslSample.Droid.Documents
{
    public class DocumentGenerator : IDocumentGenerator
    {
        public Task<string> GenerateAsync(string xml, string xsl)
        {
            return Task.Run(() =>
            {
                var builder = new StringBuilder();

                using (var xslTextReader = new StringReader(xsl))
                using (var xslReader = XmlReader.Create(xslTextReader))
                using (var xmlTextReader = new StringReader(xml))
                using (var xmlReader = XmlReader.Create(xmlTextReader))
                using (var xmlWriter = XmlWriter.Create(builder))
                {
                    var transform = new XslCompiledTransform();
                    transform.Load(xslReader);

                    transform.Transform(xmlReader, xmlWriter);
                }

                return builder.ToString();
            });
        }
    }
}