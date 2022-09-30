using EnterpriseSystem.Exceptions;
using EnterpriseSystem.Logging;
using EnterpriseSystem.Service;
using EnterpriseSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EnterpriseSystem
{
    public enum EmployeeType
    {
        Hour, Fixed
    }

    public class Manager : IValidationHelper<Employee>
    {
        public event Action<string> ModelNotify;

        #region Private fields
        public SinglyLinkedList<Employee> Employees { get; set; } = new SinglyLinkedList<Employee>();
        private readonly SinglyLinkedList<FixedEmployee> _fixedEmployees = new SinglyLinkedList<FixedEmployee>();
        private readonly SinglyLinkedList<HourEmployee> _hourEmployees = new SinglyLinkedList<HourEmployee>();
        private readonly Logger _logger;
        #endregion

        public Manager(Logger logger)
        {
            _logger = logger;
        }

        #region CRUD operations
        public void CreateEmployee(string name, string email, string phoneNumber, DateTime birthDate,
            Position position, EmployeeType empType, decimal salary)
        {
            int id = Employees.Count + 1;
            Employee? emp = null;

            switch (empType)
            {
                case EmployeeType.Hour:
                    emp = new HourEmployee(id, name, email, phoneNumber, salary, birthDate, position, _logger);
                    break;
                case EmployeeType.Fixed:
                    emp = new FixedEmployee(id, name, email, phoneNumber, salary, birthDate, position, _logger);
                    break;
            }

            if (IsValidObject(emp!))
            {
                Employees.Add(emp!);
                SortAllEmployees();
                Debug.WriteLine(Employees.Count);
                _logger.Log($"Manager added a new employee with id: {emp!.Id}", Config.FILEPATH);
            }
        }

        public void UpdateEmployee(int id, string name, string email, string phoneNumber,
            DateTime birthDate, Position position, decimal salary)
        {
            if (!IsValidInput(name, "Name")
                || !IsValidInput(email, "Email")
                || !IsValidInput(phoneNumber, "PhoneNumber")
                || !IsValidInput(birthDate, "BirthDate")
                || !IsValidInput(salary, "Salary"))
            {
                return;
            }

            Employee? emp = Employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                emp.Name = name;
                emp.Email = email;
                emp.PhoneNumber = phoneNumber;
                emp.BirthDate = birthDate;
                emp.Position = position;
                emp.Salary = salary;

                SortAllEmployees();
                SortHourEmployees();
                SortFixedEmployees();

                _logger.Log($"Employee with id: {emp.Id} has been edited", Config.FILEPATH);
            }
            else
            {
                throw new EmployeeNotFoundException(Config.EMPLOYEE_NOT_FOUND, id);
            }
        }

        public Employee GetEmployeeById(int id)
        {
            Employee? emp = Employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                return emp;
            }
            else
            {
                throw new EmployeeNotFoundException(Config.EMPLOYEE_NOT_FOUND, id);
            }
        }

        // covariation is used here
        public IEnumerable<Employee> GetEmployees()
        {
            _logger.Log("ALL EMPLOYEES LIST", Config.FILEPATH);
            foreach (var e in Employees)
            {
                _logger.Log(e.ToString(), Config.FILEPATH);
            }
            return Employees;
        }

        public IEnumerable<Employee> GetHourEmployees()
        {
            foreach (var e in Employees)
            {
                if (e is HourEmployee)
                {
                    _hourEmployees.Add((HourEmployee)e);
                }
            }

            _logger.Log("HOUR WAGE EMPLOYEES LIST", Config.FILEPATH);
            foreach (var e in _hourEmployees)
            {
                _logger.Log(e.ToString(), Config.FILEPATH);
            }
            return _hourEmployees;
        }

        public IEnumerable<Employee> GetFixedEmployees()
        {
            foreach (var e in Employees)
            {
                if (e is FixedEmployee)
                {
                    _fixedEmployees.Add((FixedEmployee)e);
                }
            }
            _logger.Log("FIXED WAGE EMPLOYEES LIST", Config.FILEPATH);
            foreach (var e in _fixedEmployees)
            {
                _logger.Log(e.ToString(), Config.FILEPATH);
            }
            return _fixedEmployees;
        }

        public void DeleteEmployee(int id)
        {
            Employee? emp = Employees?.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                Employees?.Delete(emp);
                SortAllEmployees();
                SortHourEmployees();
                SortFixedEmployees();

                _logger.Log($"Employee with id: {emp.Id} has been deleted", Config.FILEPATH);
            }
            else
            {
                throw new EmployeeNotFoundException(Config.EMPLOYEE_NOT_FOUND, id);
            }
        }
        #endregion

        #region Sorting
        private void SortAllEmployees()
        {
            Employees.SortAll(new EmployeeSorter());
        }

        // contravariation is used here
        private void SortFixedEmployees()
        {
            _fixedEmployees.SortAll(new EmployeeSorter());
        }

        private void SortHourEmployees()
        {
            _hourEmployees.SortAll(new EmployeeSorter());
        }
        #endregion

        #region Validation
        public bool IsValidObject(Employee entity)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(entity);

            if (!Validator.TryValidateObject(entity, context, results, true))
            {
                NotifyValidationFailed(results);
                return false;
            }

            return true;
        }

        public bool IsValidInput(object input, string propName)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(input);
            var attrs = typeof(Employee)
                .GetProperty(propName)?
                .GetCustomAttributes(false)
                .OfType<ValidationAttribute>()
                .ToList();

            if (!Validator.TryValidateValue(input, context, results, attrs!))
            {
                NotifyValidationFailed(results);
                return false;
            }

            return true;
        }

        public void NotifyValidationFailed(List<ValidationResult> results)
        {
            foreach (var error in results)
            {
                ShowModelMessage(error.ErrorMessage);
                _logger.Log(error.ErrorMessage, Config.FILEPATH);
                //Console.WriteLine(error.ErrorMessage);
            }
        }
        #endregion

        private void ShowModelMessage(string message)
        {
            ModelNotify.Invoke(message);
        }
    }
}
