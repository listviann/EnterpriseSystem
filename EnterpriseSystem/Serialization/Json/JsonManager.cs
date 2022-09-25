using EnterpriseSystem.Serialization.Abstract;

namespace EnterpriseSystem.Serialization.Json
{
    public class JsonManager<T> : ISerializer<T>
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
