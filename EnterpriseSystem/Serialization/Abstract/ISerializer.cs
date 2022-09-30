namespace EnterpriseSystem.Serialization.Abstract
{
    public interface ISerializer<T>
    {
        public void SerializeData(List<T> objects, string filename);
        public List<T> DeserializeData(string filename);
    }
}
