namespace EnterpriseSystem.Serialization.Abstract
{
    // Common interface for json serialization/deserialization class
    // and for xml serialization/deserialization class
    public interface ISerializer<T>
    {
        public void SerializeData(List<T> objects, string filename);
        public List<T> DeserializeData(string filename);
    }
}
