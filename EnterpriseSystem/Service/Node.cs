namespace EnterpriseSystem.Service
{
    public class Node<T> where T : class
    {
        public T Data { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T data)
        {
            Data = data;
        }
    }
}
