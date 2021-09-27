using System;
using System.Linq;

namespace BDSA2021.Assignment3
{
    public class Delegates
    {
        Action<string> ReverseString = s => Console.WriteLine(new string(s.Reverse().ToArray()));
        
        Converter<(double,double),double> Product = c => c.Item1 * c.Item2;

        Predicate<(string,int)> NumEqual = num => int.Parse(num.Item1) == num.Item2; 

    }
}
