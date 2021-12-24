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
            //var softUniContext = new SoftUniContext();
            //var result = GetEmployeesWithSalaryOver50000(softUniContext);
            //Console.WriteLine(result);

            var softUniContext = new SoftUniContext(); //create an instance of the DB SoftUni
            var result = GetEmployeesFromRandD(softUniContext);
            Console.WriteLine(result);
        }

        public static string GetEmployeesFromRandD(SoftUniContext context) 
        {
            var employeesFromRandD = context.Employees
                                            .Where(x => x.Department.Name == "Research and Development")
                                            .Select(x => new
                                            {
                                                x.FirstName,
                                                x.LastName,
                                                DepartmentName = x.Department.Name,
                                                x.Salary,
                                            })
                                            .OrderBy(x => x.Salary)
                                            .ThenByDescending(x => x.FirstName)
                                            .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in employeesFromRandD)
            {
                sb.AppendLine($"{employee.FirstName} from {employee.DepartmentName} - ${employee.Salary:F2}");
            }

            var result = sb.ToString().TrimEnd();
            return result;
        }


        
    }
}
