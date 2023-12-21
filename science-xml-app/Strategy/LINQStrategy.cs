using System.Xml.Linq;

namespace science_xml_app.Strategy
{
    public class LINQStrategy : IStrategy
    {
        public IList<Scientific> ProcessXML(string path)
        {
            var xml = XDocument.Load(path);

            var scientifics = xml.Root.Elements("Scientific")
                .Select(scientificFromXml => new Scientific
                {
                    Id = int.Parse(scientificFromXml.Element("Id").Value),
                    FullName = scientificFromXml.Element("FullName").Value,
                    Faculcy = scientificFromXml.Element("Faculcy").Value,
                    Cafedra = scientificFromXml.Element("Cafedra").Value,
                    Level = scientificFromXml.Element("Level").Value,
                    WhenGotLevel = DateTime.Parse(scientificFromXml.Element("WhenGotLevel").Value),
                })
                .ToList();

            return scientifics;
        }
    }
}
