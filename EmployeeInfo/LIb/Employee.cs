using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo.LIb
{
    public class Employee : Person
    {
        #region constructors
        // default constructor
        public Employee()
        {
            this.EmployeeType = EmployeeType.Contractual;
        }

        // 1st constructor for Constructor Overloading
        public Employee(int id, string name, DateTime dateOfBirth, DateTime joinDate, decimal salary, string jobRole)
        {
            this.ID = id;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.JoinDate = joinDate;
            this.Salary = salary;
            this.JobRole = jobRole;
            this.Age = this.GetAge(dateOfBirth);
            this.EmployeeType = EmployeeType.Contractual;
        }

        // 2nd constructor for Constructor Overloading
        public Employee(int id, string name, DateTime dateOfBirth, DateTime joinDate, decimal salary, string jobRole, EmployeeType employeeType, Department department, Designation designation)
        {
            this.ID = id;
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.JoinDate = JoinDate;
            this.Salary = salary;
            this.JobRole = jobRole;
            this.Age = this.GetAge(dateOfBirth);
            this.EmployeeType = employeeType;
            this.Department = department;
            this.Designation = designation;
        }
        #endregion

        #region properties
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Salary { get; set; }
        public string JobRole { get; set; }
        public int Age { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public Department Department { get; set; }
        public Designation Designation { get; set; }
        #endregion

        #region Methods
        public int GetAge(DateTime dateOfBirth)
        {
            DateTime onTheDate = DateTime.Now;
            TimeSpan age = DateTime.Now.Subtract(dateOfBirth);
            int years = age.Days / 365;
            return years;
        }

        // 2nd method for Method Overloading
        public int GetAge(DateTime dateOfBirth, DateTime onDate)
        {
            DateTime onTheDate = onDate;
            TimeSpan age = onTheDate.Subtract(dateOfBirth);
            int years = age.Days / 365;
            return years;
        }
        #endregion
    }

    public enum EmployeeType
    {
        Contractual = 1, Temporary = 2, Permanent = 3
    }

}
