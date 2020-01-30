using System;
using System.Collections;

namespace Iterator
{
    class Program
    {
        static IEnumerable show(){
            yield return "January";
            yield return "February";
            yield return "March";
        }
        static void Main(string[] args)
        {
            foreach (string val  in Program.show()){
                Console.WriteLine(val);
            }
        }
    }
}
