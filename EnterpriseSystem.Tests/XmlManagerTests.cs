using EnterpriseSystem.Entities;
using EnterpriseSystem.Serialization.Json;
using EnterpriseSystem.Serialization.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseSystem.Tests
{
    [TestFixture]
    internal class XmlManagerTests
    {
        private XmlManager<Employee>? _xmlManager;

        [SetUp]
        public void Setup()
        {
            _xmlManager = new XmlManager<Employee>();
        }

        [TearDown]
        public void Teardown()
        {
            _xmlManager = null;
        }

        // Failed because we cannot guarantee that floating point numbers are the same as each other
        // If we check the output or 'test.xml' file we will see that results are equal
        [Test]
        public void SerializeData_Test()
        {
            Employee emp1 = new FixedEmployee(new Guid("2e81ac7b-9ca4-4a43-9d2b-c5a931c45beb"), "Test emp 1", "test1@mail.com", "202-555-0164", 5000.2m, new DateTime(1975, 11, 24), Position.High);
            Employee emp2 = new HourEmployee(new Guid("4edb08ef-b7cd-4532-a405-c53408158331"), "Test emp 2", "test2@mail.com", "202-555-0155", 30.0m, new DateTime(1989, 12, 25), Position.Middle);
            Employee emp3 = new FixedEmployee(new Guid("213971a7-d448-4f6b-9d5b-43382a757f7f"), "Test emp 3", "test3@mail.com", "202-555-0185", 4000.0m, new DateTime(1987, 7, 21), Position.Middle);

            List<Employee> employees = new List<Employee>()
            {
                emp1, emp2, emp3
            };

            _xmlManager!.SerializeData(employees, Path.Combine(Directory.GetCurrentDirectory(), "test.xml"));

            List<Employee> expectedEmployees = _xmlManager.DeserializeData(Path.Combine(Directory.GetCurrentDirectory(), "test.xml"));

            Assert.That(employees, Is.EqualTo(expectedEmployees));
        }

        // Failed because we cannot guarantee that floating point numbers are the same as each other
        // If we check the output or 'test.xml' file we will see that results are equal
        [Test]
        public void DeserializeData_Test()
        {
            List<Employee> actualEmployees = _xmlManager.DeserializeData(Path.Combine(Directory.GetCurrentDirectory(), "test.xml"));

            Employee emp1 = new FixedEmployee(new Guid("2e81ac7b-9ca4-4a43-9d2b-c5a931c45beb"), "Test emp 1", "test1@mail.com", "202-555-0164", 5000.2m, new DateTime(1975, 11, 24), Position.High);
            Employee emp2 = new HourEmployee(new Guid("4edb08ef-b7cd-4532-a405-c53408158331"), "Test emp 2", "test2@mail.com", "202-555-0155", 30.0m, new DateTime(1989, 12, 25), Position.Middle);
            Employee emp3 = new FixedEmployee(new Guid("213971a7-d448-4f6b-9d5b-43382a757f7f"), "Test emp 3", "test3@mail.com", "202-555-0185", 4000.0m, new DateTime(1987, 7, 21), Position.Middle);

            List<Employee> expectedEmployees = new List<Employee>()
            {
                emp1, emp2, emp3
            };

            Assert.That(actualEmployees, Is.EqualTo(expectedEmployees));
        }
    }
}
