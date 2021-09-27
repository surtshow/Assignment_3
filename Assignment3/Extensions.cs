using System;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2021.Assignment3
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T> (this IEnumerable<T>[] items)
            => items.SelectMany(x => x).ToList<T>();

        public static IEnumerable<int> Filter<T>(this IEnumerable<int> items)
            => items.Where<int>(item => item % 7 == 0 && item > 42);

        public static IEnumerable<int> LeapYearFilter<T>(this IEnumerable<int> items) 
            => items.Where<int>(item => item % 400 == 0 || item % 100 != 0 && item % 4 == 0);
    }
}
