using EnterpriseSystem.Entities;
using EnterpriseSystem.Exceptions;
using EnterpriseSystem.Logging;
using EnterpriseSystem.Service;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseSystem.Tests
{
    [TestFixture]
    internal class ManagerEntityTests
    {
        private Manager _manager;

        [SetUp]
        public void Setup()
        {
            _manager = new Manager();
            _manager.ModelNotify += ShowValidationErrorMessage;

            LoggerViewModel.Logger.Notify += LogTest;
        }

        [TearDown]
        public void Teardown()
        {
            _manager.ModelNotify -= ShowValidationErrorMessage;
            LoggerViewModel.Logger.Notify -= LogTest;

            _manager = null;
        }

        #region CRUD operations testing
        [Test]
        public void CreateEmployee_Valid()
        {
            string name = "Employee 1";
            string email = "emp1@testmail.com";
            string phoneNumber = "111-222-3333";
            DateTime birthDate = new DateTime(1980, 01, 01);
            EmployeeType empType1 = EmployeeType.Fixed;
            EmployeeType empType2 = EmployeeType.Hour;
            Position position = Position.Low;
            decimal salary = 1500;

            _manager.CreateEmployee(name, email, phoneNumber, birthDate, position, empType1, salary);
            _manager.CreateEmployee(name, email, phoneNumber, birthDate, position, empType2, salary);

            Assert.IsTrue(_manager.GetEmployees().ToList().Count > 0
                && _manager.GetFixedEmployees().ToList().Count > 0
                && _manager.GetHourEmployees().ToList().Count > 0);
        }

        [Test]
        public void CreateEmployee_Invalid()
        {
            string name = " ";
            string email = "emp1testmail.com";
            string phoneNumber = "111222-33333";
            DateTime birthDate = new DateTime(1980, 01, 01);
            EmployeeType empType1 = EmployeeType.Fixed;
            Position position = Position.Low;
            decimal salary = -1500;

            _manager.CreateEmployee(name, email, phoneNumber, birthDate, position, empType1, salary);
            Assert.IsFalse(_manager.Employees.Count > 0);
        }

        [Test]
        public void UpdateEmployee_Valid()
        {
            Employee testEmployee = new FixedEmployee(Guid.NewGuid(), "Employee 1", "emp1@testmail.com", "111-222-3333",
                1000, new DateTime(1990, 8, 10), Position.Low);

            Guid testId = testEmployee.Id;

            _manager.Employees.Add(testEmployee);

            string name = "Employee 2";
            string email = "emp2@testmail.com";
            string phoneNumber = "222-333-4444";
            DateTime birthDate = new DateTime(1980, 01, 01);
            Position position = Position.High;
            decimal salary = 1500;

            _manager.UpdateEmployee(testId, name, email, phoneNumber, birthDate, position, salary);
            Employee? updatedTestEmployee = _manager.Employees.FirstOrDefault(e => e.Id == testId);

            Assert.IsTrue(updatedTestEmployee!.Name == name
                && updatedTestEmployee.Email == email
                && updatedTestEmployee.PhoneNumber == phoneNumber
                && updatedTestEmployee.BirthDate == birthDate
                && updatedTestEmployee.Position == position
                && updatedTestEmployee.Salary == salary);
        }

        [Test]
        public void UpdateEmployee_Invalid()
        {
            Employee testEmployee = new FixedEmployee(Guid.NewGuid(), "Employee 1", "emp1@testmail.com", "111-222-3333",
                1000, new DateTime(1990, 8, 10), Position.Low);

            Guid testId = testEmployee.Id;

            _manager.Employees.Add(testEmployee);

            string name = "";
            string email = "emptestmail.com";
            string phoneNumber = "222-333";
            DateTime birthDate = new DateTime(1980, 01, 01);
            Position position = Position.High;
            decimal salary = -1500;

            _manager.UpdateEmployee(testId, name, email, phoneNumber, birthDate, position, salary);
            Employee? updatedTestEmployee = _manager.Employees.FirstOrDefault(e => e.Id == testId);

            Assert.IsFalse(updatedTestEmployee!.Name == name
                && updatedTestEmployee.Email == email
                && updatedTestEmployee.PhoneNumber == phoneNumber
                && updatedTestEmployee.BirthDate == birthDate
                && updatedTestEmployee.Position == position
                && updatedTestEmployee.Salary == salary);
        }

        [Test]
        public void UpdateEmployee_InvalidWithException()
        {
            try
            {
                _manager.UpdateEmployee(Guid.NewGuid(), "testname", "testemail@mail.com", "111-222-3333", new DateTime(2000, 12, 10), Position.Low, 150);
            }
            catch
            {
                Assert.Throws<EmployeeNotFoundException>(() => { throw new EmployeeNotFoundException(); });
            }
        }

        [Test]
        public void DeleteEmployee_Valid()
        {
            Employee testEmployee = new FixedEmployee(Guid.NewGuid(), "Test employee 1", "testemp1@testmail.com", "111-222-3333",
                1000, new DateTime(1990, 01, 01), Position.Low);
            Guid testId = testEmployee.Id;

            _manager.Employees.Add(testEmployee);
            _manager.DeleteEmployee(testId);
            Assert.False(_manager.Employees.Contains(testEmployee));
        }

        [Test]
        public void DeleteEmployee_InvalidWithException()
        {
            try
            {
                _manager.DeleteEmployee(Guid.NewGuid());
            }
            catch
            {
                Assert.Throws<EmployeeNotFoundException>(() => { throw new EmployeeNotFoundException(); });
            }
        }

        [Test]
        public void GetEmployeeById_Valid()
        {
            Employee testEmployee1 = new HourEmployee(Guid.NewGuid(), "Employee 1", "emp1@testmail.com", "111-222-3333", 
                15, new DateTime(2002, 05, 05), Position.Middle);
            Guid testId = testEmployee1.Id;
            _manager.Employees.Add(testEmployee1);

            Employee testEmployee2 = _manager.GetEmployeeById(testId);

            Assert.That(testEmployee2, Is.EqualTo(testEmployee1));
        }

        [Test]
        public void GetEmployeeById_InvalidWithException()
        {
            try
            {
                _manager.GetEmployeeById(Guid.NewGuid());
            }
            catch
            {
                Assert.Throws<EmployeeNotFoundException>(() => { throw new EmployeeNotFoundException(); });
            }
        }

        [Test]
        public void GetFixedEmployees_Test()
        {
            FixedEmployee emp1 = new FixedEmployee(Guid.NewGuid(), "Emp 1", "emp1@testmail.com", "111-222-3333", 100, new DateTime(1998, 12, 10), Position.Low);
            FixedEmployee emp2 = new FixedEmployee(Guid.NewGuid(), "Emp 2", "emp2@testmail.com", "222-333-4444", 200, new DateTime(1999, 11, 26), Position.Middle);
            List<FixedEmployee> testFixedEmployees = new List<FixedEmployee>()
            {
                emp1, emp2
            };

            _manager.Employees.Add(emp1);
            _manager.Employees.Add(emp2);
            _manager.Employees.Add(new HourEmployee(Guid.NewGuid(), "Emp 3", "emp3@testmail.com", "444-555-6666", 
                30, new DateTime(2000, 01, 01), Position.High));

            List<Employee> testResultFixedEmployees = _manager.GetFixedEmployees().ToList();

            Assert.That(testResultFixedEmployees, Is.EqualTo(testFixedEmployees));
        }

        [Test]
        public void GetHourEmployees_Test()
        {
            HourEmployee emp1 = new HourEmployee(Guid.NewGuid(), "Emp 1", "emp1@testmail.com", "111-222-3333", 10, new DateTime(1998, 12, 10), Position.Low);
            HourEmployee emp2 = new HourEmployee(Guid.NewGuid(), "Emp 2", "emp2@testmail.com", "222-333-4444", 20, new DateTime(1999, 11, 26), Position.Middle);
            List<HourEmployee> testFixedEmployees = new List<HourEmployee>()
            {
                emp1, emp2
            };

            _manager.Employees.Add(emp1);
            _manager.Employees.Add(emp2);
            _manager.Employees.Add(new FixedEmployee(Guid.NewGuid(), "Emp 3", "emp3@testmail.com", "444-555-6666",
                300, new DateTime(2000, 01, 01), Position.High));

            List<Employee> testResultFixedEmployees = _manager.GetHourEmployees().ToList();

            Assert.That(testResultFixedEmployees, Is.EqualTo(testFixedEmployees));
        }
        #endregion

        #region Employees sorting testing
        [Test]
        public async Task SortAllEmployees_Test()
        {
            HourEmployee emp1 = new HourEmployee(Guid.NewGuid(), "Bob Weisman", "bobweis@testmail.com", "211-222-3333", 10, new DateTime(1998, 12, 10), Position.Low);
            HourEmployee emp2 = new HourEmployee(Guid.NewGuid(), "Ann Marston", "annmarst2@testmail.com", "224-333-4444", 20, new DateTime(1999, 11, 26), Position.Middle);
            FixedEmployee emp3 = new FixedEmployee(Guid.NewGuid(), "Carl Norton", "cnorth@testmail.com", "762-123-0981", 2000, new DateTime(1997, 04, 30), Position.High);

            List<Employee> expectedEmployeesList = new List<Employee>()
            {
                emp2, emp1, emp3
            };

            Console.WriteLine("Expected: ");
            foreach (var emp in expectedEmployeesList)
            {
                Console.WriteLine(emp);
            }

            _manager.Employees.Add(emp1);
            _manager.Employees.Add(emp2);
            _manager.Employees.Add(emp3);

            await _manager.SortAllEmployees();

            Console.WriteLine("\nActual");
            foreach (var emp in _manager.Employees)
            {
                Console.WriteLine(emp);
            }

            Assert.That(_manager.Employees, Is.EqualTo(expectedEmployeesList));
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
