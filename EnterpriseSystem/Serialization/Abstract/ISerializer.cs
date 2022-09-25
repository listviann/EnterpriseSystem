namespace EnterpriseSystem.Serialization.Abstract
{
    public interface ISerializer<T>
    {
        public void SerializeData(T objects, string filename);
        public T DeserializeData(string filename);
    }
}
