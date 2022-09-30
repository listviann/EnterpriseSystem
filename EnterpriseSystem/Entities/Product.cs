using System.ComponentModel.DataAnnotations;
using EnterpriseSystem.Service;
using Newtonsoft.Json;

namespace EnterpriseSystem.Entities
{
    [JsonObject]
    public class Product
    {
        #region Properties
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? ProductType { get; set; }

        [NonNegative]
        public decimal SellingPrice { get; set; }

        public DateTime DateCreated { get; private set; }
        #endregion

        #region Constructors
        public Product() { }
        public Product(int id, string name, string productType, decimal sellingPrice)
        {
            Id = id;
            Name = name;
            ProductType = productType;
            SellingPrice = sellingPrice;
            DateCreated = DateTime.UtcNow;
        }
        #endregion

        public override string ToString()
        {
            return $"{Id} - {Name} - {ProductType} - {SellingPrice} - {DateCreated}";
        }
    }
}
