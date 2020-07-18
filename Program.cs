﻿using System.Collections.Generic;
using System.Threading;

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
                new Employee { EmpId = 2, EmpName = "Harry" }
            };

            //... or a List<T>, etc.  
            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee { EmpId = 3, EmpName = "Marissa"}
            };

            // The IEnumerable<T> has a GetEnumerator() that allows us to walk through
            // each item in the collection
            foreach (var person in devs)
            {
                System.Console.WriteLine(person.EmpName);
            }

        }
    }
}
