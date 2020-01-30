using System;

//メソッドの受け渡しが可能になる

namespace Delegate2
{
    delegate int Del(int x,int y);

    class Class1{
        public int Method1(int x,int y){
            return x + y;
        }
        public int Method2(int x ,int y){
            return x - y;
        }
    }
    class Program
    {
        public static void Proc(int x,int y, Del proc){
            int answer = proc(x,y);//受け取ったデリゲートに引数をセットして実行
            Console.WriteLine(answer);
        }
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            //汎用メソッドに処理を移譲
            Proc(500,100,new Del(obj.Method1));
            Proc(500,100,new Del(obj.Method2));

        }
    }
}
