using System;
using System.Text;

namespace fizzbuzz1
{
    class Program
    {
        static void Main(string[] args)
        {
            for( int i = 1 ; i <= 100 ; i++ ) 
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(String.Format("{0:000}", i));               
                sb.Append(" : ");

                if ( i % 3 == 0 ) {
                    sb.Append("Fizz");
                }
                if ( i % 5 == 0 ) {
                    sb.Append("Buzz");
                }
                System.Console.WriteLine(sb.ToString());
                sb = null;
            }
            
        }
    }
}
