using SoftUni2.Data;
using System;
using System.Linq;
using System.Text;

namespace SoftUni2
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            var softUniContext = new SoftUniContext();
            var result = GetEmployeesFullInformation(softUniContext);
            Console.WriteLine(result);
        }

        public static string GetEmployeesFullInformation(SoftUniContext context) 
        {
            var employees = context.Employees
                .OrderBy(x => x.EmployeeId)
                .ToList();

            var sb = new StringBuilder();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
            }

            var result = sb.ToString().Trim();
            return result;
        }
    }
}
