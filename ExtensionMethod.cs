using System;
using System.Collections.Generic;
using System.Text;

namespace LINQExamples
{
    public static class ExtensionMethod
    {
        /// <summary>
        /// This class shows how to implement static extension method "Count()"
        /// The key is to make the method static, and pass in the "this" keyword,
        /// as part of the first paramater declaration.  
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public static int Count<T>(this IEnumerable<T> sequence)
        {
            var count = 0;
            foreach (var item in sequence)
            {
                count++;
            }
            return count;
        }
    }
}
