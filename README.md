# Xamarin-XSL
Xamarin XSL Compilation

The project solves the XSLT compilation not supported problem on UWP and uses IoC to setup the different implementations for different platforms.

## Problem
```csharp
var transform = new XslCompiledTransform();
transform.Load(xslReader);
```
throws an exception: <b>System.PlatformNotSupportedException:</b> 'Compilation of XSLT is not supported on this platform.'

## Solution
Create different DocumentGenerators for different platforms.

### UWP
```csharp
using Windows.Data.Xml.Dom;
using Windows.Data.Xml.Xsl;

...
var xmlDoc = new XmlDocument();
xmlDoc.LoadXml(xml);

var xslDoc = new XmlDocument();
xslDoc.LoadXml(xsl);

var processer = new XsltProcessor(xslDoc);
return processer.TransformToString(xmlDoc);
```


### Android
```csharp
using System.Xml;
using System.Xml.Xsl;

...
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
```
