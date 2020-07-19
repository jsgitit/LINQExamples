using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace LINQExamples
{
    public class LambdaExpressions
    {
        // Named method
        public static bool StartsWithL(string name)
        {
            return name.StartsWith("L");
        }
    
        // Named method approach (have to define an extra method)
        public class NamedMethodApproach
        {
            private static string[] cities = { "Portland", "Seattle", "Los Angeles" };
            IEnumerable<string> filteredList = cities.Where(StartsWithL);
        }

        // Anonymous method approach in the Where clause (too chatty; noisy syntax)
        public class AnonymousMethodApproach
        {
            private static string[] cities = { "Portland", "Seattle", "Los Angeles" };
            IEnumerable<string> filteredlist = cities.Where(
                delegate (string s) { return s.StartsWith("L"); 
                });
        }

        // Lambda Expression approach (much better) 
        public class LambdaExpressionApproach
        {
            private static string[] cities = { "Portland", "Seattle", "Los Angeles" };
            IEnumerable<string> filteredList = cities.Where(s => s.StartsWith("L"));
        }

        // Example Lambda Expression for a Square() function
        // Takes an int and returns an int.

        Func<int, int> square = x => x * x;

        // Exmaple Lambda Expression for Add() with a function body
        Func<int, int, int> add = (x, y) =>
        {
            var result = x + y;
            //return key word required with a method/function body
            return result;
        };

        // Action method for Lambda

        Action<int> Write = x => Console.WriteLine(x);
        // called from some other place in the program:
        // Write(3);


    }
}

