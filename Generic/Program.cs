using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start,end;

            //ArrayListとジェネリックの速度比較

            ArrayList arraylist = new ArrayList();
            start = DateTime.Now;
            for (int i=0 ; i< 10000000;i++)
            {
                arraylist.Add(i);
            }
            end = DateTime.Now;
            Console.WriteLine(end - start);

            //ジェネリックは高速　予め型指定が行われているため
            List<int> genericList = new List<int>();
            start   = DateTime.Now;
            for(int i = 0; i < 10000000; i++ ){
                genericList.Add(i);

            }
            end = DateTime.Now;
            Console.WriteLine(end - start);


        }
            
    }
}
