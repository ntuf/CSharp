using System;
using System.Linq;

namespace LinqTry
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints  = {1,2,3};
            var qs = from a in ints
                    where a % 2 == 0
                    select a ;
            foreach (var q in qs ) Console.WriteLine(q);

        }
    }
}
