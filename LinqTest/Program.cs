using System;
using System.Linq ;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linqを用いた場合、条件がパッケージ化されたので良いかもしれない
            int[] numbers = {1,2,3,4,5};
            var query = from n in numbers
                        where n >= 2 && n <= 4
                        select n;
            foreach (var a in query) Console.WriteLine(a);
            
            //Linqを用いない場合どう書くことになるか。
            //多少野暮な感じになる。
            foreach (var a in numbers){
                if ( a >= 2 && a <= 4 ) {
                    Console.WriteLine(a);
                }
            }            

        }
    }
}
