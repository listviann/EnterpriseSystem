using EnterpriseSystem.Entities;

namespace EnterpriseSystem.Service
{
    public class ProductSorter : IComparer<Product>
    {
        public int Compare(Product product, Product other)
        {
            if (!product.Name.Equals(other.Name))
            {
                return product.Name.CompareTo(other.Name);
            }
            else if (!product.SellingPrice.Equals(other.SellingPrice))
            {
                return product.SellingPrice.CompareTo(other.SellingPrice);
            }
            else
            {
                return product.DateCreated.CompareTo(other.DateCreated);
            }

            throw new Exception("Cannot compare objects");
        }
    }
}
