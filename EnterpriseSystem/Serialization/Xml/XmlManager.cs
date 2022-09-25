using EnterpriseSystem.Serialization.Abstract;

namespace EnterpriseSystem.Serialization.Xml
{
    public class XmlManager<T> : ISerializer<T>
    {
        public T DeserializeData(string filename)
        {
            throw new NotImplementedException();
        }

        public void SerializeData(T objects, string filename)
        {
            throw new NotImplementedException();
        }
    }
}
