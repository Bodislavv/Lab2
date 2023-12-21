using System.Xml;

namespace science_xml_app.Strategy
{
    public class SAXStrategy : IStrategy
    {
        public IList<Scientific> ProcessXML(string path)
        {
            var scientifics = new List<Scientific>();

            using (var reader = XmlReader.Create(path))
            {
                Scientific scientificFromXml = null;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        switch (reader.Name)
                        {
                            case "Scientific":
                                scientificFromXml = new Scientific();
                                break;
                            case "Id":
                                if (scientificFromXml != null)
                                {
                                    scientificFromXml.Id = int.Parse(reader.ReadElementContentAsString());
                                }
                                break;
                            case "FullName":
                                if (scientificFromXml != null)
                                {
                                    scientificFromXml.FullName = reader.ReadElementContentAsString();
                                }
                                break;
                            case "Faculcy":
                                if (scientificFromXml != null)
                                {
                                    scientificFromXml.Faculcy = reader.ReadElementContentAsString();
                                }
                                break;
                            case "Cafedra":
                                if (scientificFromXml != null)
                                {
                                    scientificFromXml.Cafedra = reader.ReadElementContentAsString();
                                }
                                break;
                            case "Level":
                                if (scientificFromXml != null)
                                {
                                    scientificFromXml.Level = reader.ReadElementContentAsString();
                                }
                                break;
                            case "WhenGotLevel":
                                if (scientificFromXml != null)
                                {
                                    scientificFromXml.WhenGotLevel = DateTime.Parse(reader.ReadElementContentAsString());
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    else 
                    if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "Scientific")
                    {
                        scientifics.Add(scientificFromXml);
                        scientificFromXml = null;
                    }
                }
            }

            return scientifics;
        }
    }
}
