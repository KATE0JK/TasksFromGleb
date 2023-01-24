using System.Xml;
using System.Xml.Linq;

namespace TestProject1;

public class XmlParser
{
    private string _xmlFilePath;

    public XmlParser(string path)
    {
        _xmlFilePath = path;
    }
    
    public IEnumerable<string> GetValuesByTag(string tag)
    {
        XElement root = XElement.Load(_xmlFilePath);

        return root.Descendants(tag)
            .Select(item => item.Value);
    }
}