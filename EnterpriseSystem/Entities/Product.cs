using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using EnterpriseSystem.Service;
using Newtonsoft.Json;

namespace EnterpriseSystem.Entities
{
    [JsonObject]
    public class Product
    {
        #region Properties
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? ProductType { get; set; }

        [NonNegative]
        public decimal SellingPrice { get; set; }

        public DateTime DateCreated { get; set; }
        #endregion

        #region Constructors
        public Product() { }
        public Product(Guid id, string name, string productType, decimal sellingPrice)
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
