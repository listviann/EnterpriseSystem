namespace EnterpriseSystem.Exceptions
{
    [Serializable]
    public class ProductNotFoundException : Exception
    {
        public Guid ProductId { get; set; }

        public ProductNotFoundException()
        { }

        public ProductNotFoundException(string message)
            : base(message) { }

        public ProductNotFoundException(string message, Exception inner)
            : base(message, inner) { }

        public ProductNotFoundException(string message, Guid productId)
            : this(message)
        {
            ProductId = productId;
        }
    }
}
