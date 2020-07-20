using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Queries
{
    public static class MyLINQ
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            var result = new List<T>();
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        // Deferred execution Filter will act more like LINQ's Where() operator.
        public static IEnumerable<T> DeferredExecutionFilter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    // return one item at a time, only when requested by the caller.
                    yield return item;
                }
            }
        }
    }
}
