﻿namespace EnterpriseSystem.Exceptions
{
    [Serializable]
    public class ProductNotFoundException : Exception
    {
        public int ProductId { get; set; }

        public ProductNotFoundException()
        { }

        public ProductNotFoundException(string message)
            : base(message) { }

        public ProductNotFoundException(string message, Exception inner)
            : base(message, inner) { }

        public ProductNotFoundException(string message, int productId)
            : this(message)
        {
            ProductId = productId;
        }
    }
}
