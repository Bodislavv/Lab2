namespace science_xml_app.Strategy
{
    public interface IStrategy
    {
        IList<Scientific> ProcessXML(string path);
    }
}
