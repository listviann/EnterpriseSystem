using EnterpriseSystem.Service;
using System.ComponentModel.DataAnnotations;
using EnterpriseSystem.Exceptions;
using EnterpriseSystem.Logging;
using System.Xml.Serialization;

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

        protected readonly Logger _logger;

        private static readonly Dictionary<Position, decimal> _bonusList = new Dictionary<Position, decimal>()
        {
            [Position.Low] = 1500,
            [Position.Middle] = 3000,
            [Position.High] = 5000
        };

        protected decimal _bonus;
        protected Position _position;

        #region Properties
        public int Id { get; set; }

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

        public SinglyLinkedList<Product> Products { get; set; } = new();

        public Position Position
        {
            get => _position;
            set
            {
                _position = value;
                _bonus = _bonusList[_position];
                //Debug.WriteLine(_bonus);
            }
        }

        public abstract decimal AverageIncome { get; }
        #endregion

        #region Constructors
        protected Employee() { }
        protected Employee(int id, string name, string email, string phoneNumber,
            decimal salary, DateTime birthDate, Position position, Logger logger)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            BirthDate = birthDate;
            Position = position;
            Salary = salary;
            _logger = logger;
        }
        #endregion

        #region CRUD operations
        public virtual void CreateProduct(string name, string productType, decimal sellingPrice)
        {
            int productId = Products.Count + 1;
            Product product = new(productId, name, productType, sellingPrice);

            if (IsValidObject(product))
            {
                Products.Add(product);
            }
        }

        public virtual void UpdateProduct(int id, string name, string productType, decimal sellingPrice)
        {
            if (!IsValidInput(name, "Name")
                || !IsValidInput(productType, "ProductType")
                || !IsValidInput(sellingPrice, "SellingPrice"))
            {
                return;
            }

            Product? p = Products.FirstOrDefault(p => p.Id == id);
            if (p != null)
            {
                p.Name = name;
                p.ProductType = productType;
                p.SellingPrice = sellingPrice;
            }
            else
            {
                throw new ProductNotFoundException("Product not found", id);
            }
        }

        public virtual SinglyLinkedList<Product> GetProducts()
        {
            _logger.Log("Products created by employee", Config.FILEPATH);
            foreach (var p in Products)
            {
                _logger.Log(p.ToString(), Config.FILEPATH);
            }
            return Products;
        }

        public virtual void DeleteProduct(int id)
        {
            Product? p = Products.FirstOrDefault(p => p.Id == id);
            if (p != null)
            {
                Products.Delete(p);
            }
            else
            {
                throw new ProductNotFoundException("Product not found", id);
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
                //Console.WriteLine(error.ErrorMessage);
                OnModelNotifying(error.ErrorMessage);
                _logger.Log(error.ErrorMessage, Config.FILEPATH);
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

