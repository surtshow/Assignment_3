using System;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2021.Assignment3
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T> (this IEnumerable<T>[] items)
        => items.SelectMany(x => x).ToList<T>();

    }
}
