using System.Xml;
using System.Xml.Xsl;

namespace science_xml_app
{
    public class XmlToHtmlConvertService
    {
        public void XmlToHTML(string xmlFilePaath, string xsltFilePath, string outputFilePath)
        {
            var xslt = new XslCompiledTransform();
            xslt.Load(xsltFilePath);

            using (var writer = XmlWriter.Create(outputFilePath))
            {
                xslt.Transform(xmlFilePaath, writer);
            }
        }
    }
}
