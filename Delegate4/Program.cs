using System;
using System.Threading.Tasks;
//using System.Threading.Thread;


//http://gomocool.net/gomokulog/?p=762


namespace Delegate4
{
    public class Program
    {
        static void Main()
        {
            Object lockObj = new Object();

            int count = 0;

            Task task = new Task(() =>
            {
            	//count に +10 を5回で計50を追加する
            	for (int i = 0; i < 5; i++)
            	{
            		System.Threading.Thread.Sleep(i);
            		lock (lockObj)
            		{
            			int tmpCount = count;
            			Console.WriteLine("別スレッド");
            			count = tmpCount + 10;
            		}
            	}
            });
            task.Start();

            //countから-5の5回で計-25を引く
            for (int i = 0; i < 5; i++)
            {
            	System.Threading.Thread.Sleep(5 - i);
            	lock (lockObj)
            	{
            		int tmpCount = count;
            		Console.WriteLine("本体スレッド");
            		count = tmpCount - 5;
            	}
            }

            task.Wait();

            //合計は50-25で25？
            Console.WriteLine(count);

        }

    }
}
