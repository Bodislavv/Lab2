using System.Xml;

namespace science_xml_app.Strategy
{
    public class DOMStrategy : IStrategy
    {
        public IList<Scientific> ProcessXML(string path)
        {
            var scientifics = new List<Scientific>();

            var xml = new XmlDocument();
            xml.Load(path);

            foreach (XmlNode GraduateNode in xml.SelectNodes("//Scientific"))
            {
                var scientificFromXml = new Scientific();

                foreach (XmlNode propertyNode in GraduateNode.ChildNodes)
                {
                    switch (propertyNode.Name)
                    {
                        case "Id":
                            scientificFromXml.Id = int.Parse(propertyNode.InnerText);
                            break;
                        case "FullName":
                            scientificFromXml.FullName = propertyNode.InnerText;
                            break;
                        case "Faculcy":
                            scientificFromXml.Faculcy = propertyNode.InnerText;
                            break;
                        case "Cafedra":
                            scientificFromXml.Cafedra = propertyNode.InnerText;
                            break;
                        case "Level":
                            scientificFromXml.Level = propertyNode.InnerText;
                            break;
                            break;
                        case "EnterDate":
                            scientificFromXml.WhenGotLevel = DateTime.Parse(propertyNode.InnerText);
                            break;
                        default:
                            break;
                    }
                }

                scientifics.Add(scientificFromXml);
            }

            return scientifics;
        }
    }
}
