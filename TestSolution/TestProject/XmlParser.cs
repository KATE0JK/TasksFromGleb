using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TestProject1;

public class XmlParser
{
    private readonly string _xmlFilePath;

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

    public T? DeserializeObject<T>() where T : class
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
        T obj;

        using (XmlReader reader = XmlReader.Create(_xmlFilePath))
        {
            obj = (T) xmlSerializer.Deserialize(reader);
        }

        return obj;
    }
}