using EnterpriseSystem.Service;
using EnterpriseSystem.Logging;

namespace EnterpriseSystem.Entities
{
    public class HourEmployee : Employee
    {
        public override decimal AverageIncome => 20.8m * 8 * Salary + _bonus;

        #region Constructors
        public HourEmployee() { }
        public HourEmployee(int id, string name, string email, string phoneNumber, 
            decimal salary, DateTime birthDate, Position position, Logger logger)
            : base(id, name, email, phoneNumber, salary, birthDate, position, logger)
        { }
        #endregion

        #region CRUD operations
        public override void CreateProduct(string name, string productType, decimal sellingPrice)
        {
            _logger.Log($"Hour salary employee [{Id} - {Name}] created a new product.", Config.FILEPATH);
            base.CreateProduct(name, productType, sellingPrice);
        }

        public override SinglyLinkedList<Product> GetProducts()
        {
            _logger.Log($"Products created by a fixed salary employee [{Id} - {Name}]:", Config.FILEPATH);
            return base.GetProducts();
        }

        public override void UpdateProduct(int id, string name, string productType, decimal sellingPrice)
        {
            _logger.Log($"Hour salary employee [{Id} - {Name}] updated the product.", Config.FILEPATH);
            base.UpdateProduct(id, name, productType, sellingPrice);
        }

        public override void DeleteProduct(int id)
        {
            _logger.Log($"Hour salary employee [{Id} - {Name}] deleted the product.", Config.FILEPATH);
            base.DeleteProduct(id);
        }
        #endregion
        public override string ToString()
        {
            return base.ToString() + $" - {AverageIncome}";
        }
    }
}
