using System;
using System.Collections.Generic;
using System.Linq;

namespace BDSA2021.Assignment3
{
    public static class Extensions
    {
        public static IEnumerable<T> Flatten<T> (this IEnumerable<T>[] items)
        => items.SelectMany(x => x).ToList<T>();

        public static bool IsSecure<T> (this Uri item) => item.Scheme == Uri.UriSchemeHttps;

        public static int WordCount<T> (this string str) => throw new NotImplementedException();
    }
}
