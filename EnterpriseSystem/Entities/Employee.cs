using EnterpriseSystem.Service;
using System.ComponentModel.DataAnnotations;
using EnterpriseSystem.Exceptions;
using EnterpriseSystem.Logging;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace EnterpriseSystem.Entities
{
    public enum Position
    {
        Low, Middle, High
    }

    [XmlInclude(typeof(HourEmployee))]
    [XmlInclude(typeof(FixedEmployee))]
    public abstract class Employee : IValidationHelper<Product>
    {
        public event Action<string> ModelNotify;

        private static readonly Dictionary<Position, decimal> _bonusList = new Dictionary<Position, decimal>()
        {
            [Position.Low] = 1500,
            [Position.Middle] = 3000,
            [Position.High] = 5000
        };

        protected decimal _bonus;
        protected Position _position;

        #region Properties
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string? Name { get; set; }

        [Required]
        [RegularExpression(@"[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Incorrect email")]
        public string? Email { get; set; }

        [Required]
        [RegularExpression(@"\d{3}-\d{3}-\d{4}", ErrorMessage = "Incorrect phone number")]
        public string? PhoneNumber { get; set; }

        [NonNegative]
        public decimal Salary { get; set; }

        [BirthDateMaxValue]
        public DateTime BirthDate { get; set; }

        public List<Product> ProductsList { get; set; } = new();

        public Position Position
        {
            get => _position;
            set
            {
                _position = value;
                _bonus = _bonusList[_position];
            }
        }

        public abstract decimal AverageIncome { get; }
        #endregion

        #region Constructors
        protected Employee() { }
        protected Employee(Guid id, string name, string email, string phoneNumber,
            decimal salary, DateTime birthDate, Position position)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
            Position = position;
            Salary = salary;
        }
        #endregion

        #region CRUD operations
        public virtual void CreateProduct(string name, string productType, decimal sellingPrice)
        {
            Guid productId = Guid.NewGuid();
            Product product = new(productId, name, productType, sellingPrice);

            if (IsValidObject(product))
            {
                ProductsList.Add(product);
                ProductsList.Sort(new ProductSorter());
            }
        }

        public virtual void UpdateProduct(Guid id, string name, string productType, decimal sellingPrice)
        {
            if (!IsValidInput(name, "Name")
                || !IsValidInput(productType, "ProductType")
                || !IsValidInput(sellingPrice, "SellingPrice"))
            {
                return;
            }

            Product? p = ProductsList.FirstOrDefault(p => p.Id == id);
            if (p != null)
            {
                p.Name = name;
                p.ProductType = productType;
                p.SellingPrice = sellingPrice;
                ProductsList.Sort(new ProductSorter());
            }
            else
            {
                throw new ProductNotFoundException(Config.PRODUCT_NOT_FOUND, id);
            }
        }

        public virtual void GetProducts()
        {
            LoggerViewModel.Logger.Log("Products created by employee", Config.FILEPATH);
            foreach (var p in ProductsList)
            {
                LoggerViewModel.Logger.Log(p.ToString(), Config.FILEPATH);
            }
        }

        public virtual void DeleteProduct(Guid id)
        {
            Product? p = ProductsList.FirstOrDefault(p => p.Id == id);
            if (p != null)
            {
                ProductsList.Remove(p);
                ProductsList.Sort(new ProductSorter());
            }
            else
            {
                throw new ProductNotFoundException(Config.PRODUCT_NOT_FOUND, id);
            }
        }
        #endregion

        #region Validation
        public bool IsValidObject(Product entity)
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
            var attrs = typeof(Product)
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
                OnModelNotifying(error.ErrorMessage);
                LoggerViewModel.Logger.Log(error.ErrorMessage, Config.FILEPATH);
            }
        }
        #endregion

        public override string ToString()
        {
            return $"{Id} - {Name} - {Email} - {PhoneNumber} - {Salary} - {BirthDate} - {Position}";
        }

        private void OnModelNotifying(string message)
        {
            ModelNotify.Invoke(message);
        }
    }
}

