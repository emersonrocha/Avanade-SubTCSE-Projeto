using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee.Entities
{
    public record Employee : BaseEntity<string>
    {
        public Employee(
            string firstName, 
            string surName, 
            DateTime birthday, 
            bool active, 
            decimal salary, 
            EmployeeRole.Entities.EmployeeRole employeeRole
            )
        {
            FirstName = firstName;
            SurName = surName;
            Birthday = birthday;
            this.active = active;
            Salary = salary;
            EmployeeRole = employeeRole;
        }

        public string  FirstName { get; init; }

        public string  SurName { get; init; }

        public DateTime Birthday { get; init; }

        public bool active { get; init; }

        public decimal Salary { get; init; }

        public EmployeeRole.Entities.EmployeeRole EmployeeRole { get; init; }
    }
}
