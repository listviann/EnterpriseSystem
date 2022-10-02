using EnterpriseSystem.Service;
using EnterpriseSystem.Logging;

namespace EnterpriseSystem.Entities
{
    public class FixedEmployee : Employee
    {
        public override decimal AverageIncome =>  Salary + _bonus;

        #region Constructors
        public FixedEmployee() { }
        public FixedEmployee(Guid id, string name, string email, string phoneNumber, 
            decimal salary, DateTime birthDate, Position position)
            :base(id, name, email, phoneNumber, salary, birthDate, position)
        { }
        #endregion

        #region CRUD operations
        public override void CreateProduct(string name, string productType, decimal sellingPrice)
        {
            LoggerViewModel.Logger.Log($"Fixed salary employee [{Id} - {Name}] created a new product.", Config.FILEPATH);
            base.CreateProduct(name, productType, sellingPrice);
        }

        public override void UpdateProduct(Guid id, string name, string productType, decimal sellingPrice)
        {
            LoggerViewModel.Logger.Log($"Fixed salary employee [{Id} - {Name}] updated the product with id: {id}.", Config.FILEPATH);
            base.UpdateProduct(id, name, productType, sellingPrice);
        }

        public override void DeleteProduct(Guid id)
        {
            LoggerViewModel.Logger.Log($"Fixed salary employee [{Id} - {Name}] deleted the product with id: {id}.", Config.FILEPATH);
            base.DeleteProduct(id);
        }

        public override void GetProducts()
        {
            LoggerViewModel.Logger.Log($"Products created by a fixed salary employee [{Id} - {Name}]:", Config.FILEPATH);
            base.GetProducts();
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() + $" - {AverageIncome}";
        }
    }
}
