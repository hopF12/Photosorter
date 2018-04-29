using System;
using System.Collections.Generic;
using System.Linq;

namespace Helper.Others
{
    public static class LinqAdapter
    {
        public static IEnumerable<TSource> Distinct<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> predicate)
        {
            var list = source.ToList();
            var result = list.Where(s => list.Count(p => predicate.Invoke(s).Equals(predicate.Invoke(p))) >= 1).ToList();
            return result;
        }
    }
}