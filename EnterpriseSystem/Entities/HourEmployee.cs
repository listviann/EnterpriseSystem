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
            decimal salary, DateTime birthDate, Position position)
            : base(id, name, email, phoneNumber, salary, birthDate, position)
        { }
        #endregion

        #region CRUD operations
        public override void CreateProduct(string name, string productType, decimal sellingPrice)
        {
            LoggerViewModel.Logger.Log($"Hour salary employee [{Id} - {Name}] created a new product.", Config.FILEPATH);
            base.CreateProduct(name, productType, sellingPrice);
        }

        public override void GetProducts()
        {
            LoggerViewModel.Logger.Log($"Products created by a fixed salary employee [{Id} - {Name}]:", Config.FILEPATH);
            base.GetProducts();
        }

        public override void UpdateProduct(int id, string name, string productType, decimal sellingPrice)
        {
            LoggerViewModel.Logger.Log($"Hour salary employee [{Id} - {Name}] updated the product with id: {id}", Config.FILEPATH);
            base.UpdateProduct(id, name, productType, sellingPrice);
        }

        public override void DeleteProduct(int id)
        {
            LoggerViewModel.Logger.Log($"Hour salary employee [{Id} - {Name}] deleted the product with id: {id}", Config.FILEPATH);
            base.DeleteProduct(id);
        }
        #endregion
        public override string ToString()
        {
            return base.ToString() + $" - {AverageIncome}";
        }
    }
}
