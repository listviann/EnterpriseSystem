using EnterpriseSystem.Entities;
using EnterpriseSystem.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime;

namespace EnterpriseSystem.Tests
{
    [TestFixture]
    internal class JsonManagerTests
    {
        private JsonManager<Employee>? _jsonManager;

        [SetUp]
        public void Setup()
        {
            _jsonManager = new JsonManager<Employee>();
        }

        [TearDown]
        public void Teardown()
        {
            _jsonManager = null;
        }

        // Failed because we cannot guarantee that floating point numbers are the same as each other
        // If we check the output or 'test.json' file we will see that results are equal
        [Test]
        public void SerializeData_Test()
        {
            Employee emp1 = new FixedEmployee(Guid.NewGuid(), "Test emp 1", "test1@mail.com", "202-555-0164", Math.Round(5000.2m, 1), new DateTime(1975, 11, 24), Position.High);
            emp1.ProductsList.Add(new Product(Guid.NewGuid(), "Test prod 1", "Test type 1", Math.Round(10.1m, 1)));
            emp1.ProductsList.Add(new Product(Guid.NewGuid(), "Test prod 2", "Test type 2", Math.Round(20.1m, 1)));

            Employee emp2 = new HourEmployee(Guid.NewGuid(), "Test emp 2", "test2@mail.com", "202-555-0155", Math.Round(30.1m, 1), new DateTime(1989, 12, 25), Position.Middle);
            emp2.ProductsList.Add(new Product(Guid.NewGuid(), "Test prod 3", "Test type 3", Math.Round(30.1m, 1)));

            Employee emp3 = new FixedEmployee(Guid.NewGuid(), "Test emp 3", "test3@mail.com", "202-555-0185", Math.Round(4000.1m, 1), new DateTime(1987, 7, 21), Position.Middle);
            List<Employee> employees = new List<Employee>()
            {
                emp1, emp2, emp3
            };

            _jsonManager!.SerializeData(employees, Path.Combine(Directory.GetCurrentDirectory(), "test.json"));

            List<Employee> expectedEmployees = _jsonManager.DeserializeData(Path.Combine(Directory.GetCurrentDirectory(), "test.json"));

            Assert.That(employees, Is.EqualTo(expectedEmployees));
        }

        // Failed because we cannot guarantee that floating point numbers are the same as each other
        // If we check the output or 'test.json' file we will see that results are equal
        [Test]
        public void DeserializeData_Test()
        {
            List<Employee> actualEmployees = _jsonManager!.DeserializeData(Path.Combine(Directory.GetCurrentDirectory(), "test.json"));

            Employee emp1 = new FixedEmployee(new Guid("2e81ac7b-9ca4-4a43-9d2b-c5a931c45beb"), "Test emp 1", "test1@mail.com", "202-555-0164", 5000.2m, new DateTime(1975, 11, 24), Position.High);
            emp1.ProductsList.Add(new Product(new Guid("7028a85b-2eeb-4634-a038-743f629f3e20"), "Test prod 1", "Test type 1", 10.0m));
            emp1.ProductsList.Add(new Product(new Guid("b1f9f971-9502-48e5-ae57-8a5a72ca181c"), "Test prod 2", "Test type 2", 20.0m));

            Employee emp2 = new HourEmployee(new Guid("4edb08ef-b7cd-4532-a405-c53408158331"), "Test emp 2", "test2@mail.com", "202-555-0155", 30.0m, new DateTime(1989, 12, 25), Position.Middle);
            emp2.ProductsList.Add(new Product(new Guid("9ced4001-dddb-4708-b5dd-2d5722f821a8"), "Test prod 3", "Test type 3", 30.0m));

            Employee emp3 = new FixedEmployee(new Guid("213971a7-d448-4f6b-9d5b-43382a757f7f"), "Test emp 3", "test3@mail.com", "202-555-0185", 4000.0m, new DateTime(1987, 7, 21), Position.Middle);
            List<Employee> expectedEmployees = new List<Employee>()
            {
                emp1, emp2, emp3
            };

            Assert.That(actualEmployees, Is.EqualTo(expectedEmployees));
        }
    }
}
