using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInfo.LIb
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        #region Methods
        public static string GetFullName(string firstName, string lastName)
        {
            return (firstName + " " + lastName).Trim();
        }
        #endregion
    }
}
