using EnterpriseSystem.Entities;
using EnterpriseSystem.Serialization.Abstract;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EnterpriseSystem.Serialization.Xml
{
    // class that contains logic for json serialization/deserialization
    public class XmlManager<T> : ISerializer<T>
    {
        private readonly XmlSerializer _formatter = new XmlSerializer(typeof(List<Employee>));

        public List<T> DeserializeData(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                List<T> objects = (List<T>)_formatter.Deserialize(fs)!;
                return objects;
            }
        }

        public void SerializeData(List<T> objects, string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                _formatter.Serialize(fs, objects);
            }
        }
    }
}
