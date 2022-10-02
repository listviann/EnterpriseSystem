namespace EnterpriseSystem.Exceptions
{
    public class EmployeeNotFoundException : Exception
    {
        public Guid EmployeeId { get; set; }

        public EmployeeNotFoundException() { }

        public EmployeeNotFoundException(string message)
            : base(message) { }

        public EmployeeNotFoundException(string message, Exception inner)
            : base(message, inner) { }

        public EmployeeNotFoundException(string message, Guid employeeId)
            : this(message)
        {
            EmployeeId = employeeId;
        }
    }
}
