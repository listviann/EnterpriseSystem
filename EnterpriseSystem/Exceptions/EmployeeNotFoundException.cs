using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseSystem.Exceptions
{
    public class EmployeeNotFoundException : Exception
    {
        public int EmployeeId { get; set; }

        public EmployeeNotFoundException() { }

        public EmployeeNotFoundException(string message)
            : base(message) { }

        public EmployeeNotFoundException(string message, Exception inner)
            : base(message, inner) { }

        public EmployeeNotFoundException(string message, int employeeId)
            : this(message)
        {
            EmployeeId = employeeId;
        }
    }
}
