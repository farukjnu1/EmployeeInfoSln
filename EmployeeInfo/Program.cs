using EmployeeInfo.LIb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("INPUTs\n======");
                Console.Write("\nID: ");
                int id = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();
                
                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();
                
                Console.Write("Date of Birth (yyyy/MM/dd): ");
                DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                
                Console.Write("Joining Date (yyyy/MM/dd): ");
                DateTime joiningDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Salary: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Job Roles: ");
                string jobRole = Console.ReadLine();

                Employee newEmployee = new Employee(id, Person.GetFullName(firstName,lastName), birthDate, joiningDate, salary, jobRole);
                
                Console.WriteLine("\n\nOUTPUTs\n=======");
                Console.WriteLine(@"Employee ID: " + newEmployee.ID
                    + "\nName: " + newEmployee.Name
                    + "\nAge: " + newEmployee.Age
                    + "\nJoining Date: " + newEmployee.JoinDate.ToShortDateString()
                    + "\nSalary: " + newEmployee.Salary
                    + "\nRole plays: " + newEmployee.JobRole);
                
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
