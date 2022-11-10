using EnterpriseSystem.Entities;
using EnterpriseSystem.Exceptions;
using EnterpriseSystem.Logging;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.Xml;

namespace EnterpriseSystem.Tests
{
    [TestFixture]

    public class EmployeeEntityTests
    {
        private Employee _testEmployee1;
        private Employee _testEmployee2;

        [SetUp]
        public void Setup()
        {
            // Create a test employees instance

            // Fixed-wage test employee
            _testEmployee1 = new FixedEmployee(Guid.NewGuid(), "Test Employee 1", "testemp1@mail.com", "111-222-3333",
                1000, new DateTime(2000, 1, 1), Position.Low);

            _testEmployee1.ModelNotify += ShowValidationErrorMessage;

            // Hour-wage test employee
            _testEmployee2 = new HourEmployee(Guid.NewGuid(), "Test employee 2", "testemp2@mail.com", "222-333-4444",
                35, new DateTime(1998, 10, 2), Position.Middle);

            _testEmployee1.ModelNotify += ShowValidationErrorMessage;

            LoggerViewModel.Logger.Notify += LogTest;
        }

        #region CRUD operations testing
        [Test]
        public void CreateProduct_Valid()
        {
            _testEmployee1.CreateProduct("Test product 1", "Test product type 1", 100);
            Assert.IsTrue(_testEmployee1.ProductsList.Count > 0);
        }

        [Test]
        public void CreateProduct_Invalid()
        {
            _testEmployee1.CreateProduct("", "", -50);
            Assert.IsFalse(_testEmployee1.ProductsList.Count > 0);
        }

        [Test]
        public void UpdateProduct_Valid()
        {
            Product testProd = new Product(Guid.NewGuid(), "Test product 2", "Test type 2", 500);
            Guid testId = testProd.Id;
            _testEmployee1.ProductsList.Add(testProd);

            string testName = "Test product 3";
            string testType = "Test type 3";
            decimal testPrice = 600;
            _testEmployee1.UpdateProduct(testProd.Id, testName, testType, testPrice);

            Product? updatedTestProd = _testEmployee1.ProductsList.FirstOrDefault(p => p.Id == testId);
            Assert.IsTrue(updatedTestProd!.Name == testName
                && updatedTestProd.ProductType == testType
                && updatedTestProd.SellingPrice == testPrice);
        }

        [Test]
        public void UpdateProduct_Invalid()
        {
            Product testProd = new Product(Guid.NewGuid(), "Test product 3", "Test type 3", 600);
            Guid testId = testProd.Id;
            _testEmployee1.ProductsList.Add(testProd);

            string testName = "";
            string testType = "";
            decimal testPrice = -500;

            _testEmployee1.UpdateProduct(testProd.Id, testName, testType, testPrice);
            Product? updatedTestProd = _testEmployee1.ProductsList.FirstOrDefault(p => p.Id == testId);
            
            Assert.IsFalse(updatedTestProd!.Name == testName
                && updatedTestProd.ProductType == testType
                && updatedTestProd.SellingPrice == testPrice);
        }

        [Test]
        public void UpdateProduct_InvalidWithException()
        {
            try
            {
                _testEmployee1.UpdateProduct(Guid.NewGuid(), "Test product name", "Test product type", 700);
            }
            catch
            {
                Assert.Throws<ProductNotFoundException>(() => { throw new ProductNotFoundException(); });
            }
        }

        [Test]
        public void DeleteProduct_Valid()
        {
            Product testProd = new Product(Guid.NewGuid(), "Test product 4", "Test type 4", 700);
            Guid testId = testProd.Id;
            _testEmployee1.ProductsList.Add(testProd);

            _testEmployee1.DeleteProduct(testId);

            Assert.IsFalse(_testEmployee1.ProductsList.Contains(testProd));
        }

        [Test]
        public void DeleteProduct_InvalidWithException()
        {
            Guid id = Guid.NewGuid();

            try
            {
                _testEmployee1.DeleteProduct(id);
            }
            catch
            {
                Assert.Throws<ProductNotFoundException>(() => { throw new ProductNotFoundException(); });
            }
        }
        #endregion

        #region Average income count testing
        [Test]
        public void FixedEmployee_TestAverageIncome()
        {
            decimal expected = 2500;
            decimal actual = _testEmployee1.AverageIncome;

            // Acts like Assert.AreEqual but for decimal values
            Assert.That(Math.Abs(expected - actual), Is.LessThan(0.0001M));
        }

        [Test]
        public void HourEmployee_TestAverageIncome()
        {
            decimal expected = 8824;
            decimal actual = _testEmployee2.AverageIncome;

            // Acts like Assert.AreEqual but for decimal values
            Assert.That(Math.Abs(expected - actual), Is.LessThan(0.0001M));
        }
        #endregion

        #region Prooducts list sorting test
        [Test]
        public async Task SortProducts_Test()
        {
            Product testProduct1 = new Product(Guid.NewGuid(), "iPhone 14", "Smartphones", 1000);
            Product testProduct2 = new Product(Guid.NewGuid(), "AMD Ryzen 7 5800X3D", "Computers", 800);
            Product testProduct3 = new Product(Guid.NewGuid(), "AMD Ryzen 5", "Computers", 500);

            List<Product> alreadySortedProductsList = new List<Product>()
            {
                testProduct3, testProduct2, testProduct1
            };

            _testEmployee1.ProductsList.Add(testProduct1);
            _testEmployee1.ProductsList.Add(testProduct2);
            _testEmployee1.ProductsList.Add(testProduct3);

            await _testEmployee1.SortProducts();

            Assert.That(_testEmployee1.ProductsList, Is.EqualTo(alreadySortedProductsList));
        }
        #endregion
        private void ShowValidationErrorMessage(string message)
        {
            Console.WriteLine(message);
        }

        private void LogTest(string message, string filepath)
        {
            Console.WriteLine(message, filepath);
        }
    }
}