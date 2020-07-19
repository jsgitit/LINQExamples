using Microsoft.CSharp.RuntimeBinder;
using System.Collections.Generic;
using System.Linq;

namespace LINQExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // IEnumerable hides the source of data, whether it's an Array...
            IEnumerable<Employee> devs = new Employee[]
            {
                new Employee { EmpId = 1, EmpName = "Jon"},
                new Employee { EmpId = 2, EmpName = "Harry" },
                new Employee { EmpId = 2, EmpName = "Alice" }

            };

            //... or a List<T>, etc.  
            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { EmpId = 3, EmpName = "Marissa"},
                new Employee { EmpId = 3, EmpName = "Scott"},
                new Employee { EmpId = 3, EmpName = "Patrick"}


            };

            // The IEnumerable<T> has a GetEnumerator() that allows us to walk through
            // each item in the collection.  Effectively foreach is using this.
            foreach (var employee in devs.Where(e => e.EmpName.StartsWith("J")))
            {
                System.Console.WriteLine(employee.EmpName);

            }

            System.Console.WriteLine("***");
            foreach (var employee in devs.Where(e => e.EmpName.Length == 5)
                                         .OrderBy(e => e.EmpName))
            {
                System.Console.WriteLine(employee.EmpName);
            }

            // use custom extension method called "Count()" in Extension Method class.
            System.Console.WriteLine("The number of items is " + devs.Count());
        }
    }
}
