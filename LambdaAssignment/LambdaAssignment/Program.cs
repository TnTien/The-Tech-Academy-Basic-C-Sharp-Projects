using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  instantiates and intializes List of type Employee
            List<Employee> employees = new List<Employee>()
            {
                new Employee { ID = 1, firstName = "Joe", lastName = "Smith" },
                new Employee { ID = 2, firstName = "Jessica", lastName = "Jones" },
                new Employee { ID = 3, firstName = "John", lastName = "Jacobs" },
                new Employee { ID = 4, firstName = "Rob", lastName = "Last" },
                new Employee { ID = 5, firstName = "Lynda", lastName = "Street" },
                new Employee { ID = 6, firstName = "Joe", lastName = "Doe" },
                new Employee { ID = 7, firstName = "Karen", lastName = "Town" },
                new Employee { ID = 8, firstName = "Jane", lastName = "Doe" },
                new Employee { ID = 9, firstName = "Will", lastName = "Smith" },
                new Employee { ID = 10, firstName = "Joe", lastName = "Valley" }
            };
            
            //  for each loop
            foreach (Employee employee in employees)
            {
                //  if firstname is equal to Joe, will add to new list
                List<Employee> employeeJoe = new List<Employee>();
                if (employee.firstName == "Joe")
                {
                    employeeJoe.Add(employee);
                }
                //  prints out new list
                foreach (Employee joe in employeeJoe)
                {
                    Console.WriteLine("{0}: {1} {2}", joe.ID, joe.firstName, joe.lastName);
                }
            }

            //  lambda expression, will add all firstName "Joe" to joeEmployee List
            List<Employee> joeEmployee = employees.Where(x => x.firstName == "Joe").ToList();
            //  will print each item in joeEmployee list
            foreach (Employee joe in joeEmployee)
            {
                Console.WriteLine("{0}: {1} {2}", joe.ID, joe.firstName, joe.lastName);
            }

            //  lambda expression where any employee.ID is greater than 5 will get added to List
            List<Employee> employeeID = employees.Where(x => x.ID > 5).ToList();
            //  prints each item in employeeID list
            foreach (Employee id in employeeID)
            {
                Console.WriteLine("{0}: {1} {2}", id.ID, id.firstName, id.lastName);
            }


            Console.ReadLine();
        }
    }
}
