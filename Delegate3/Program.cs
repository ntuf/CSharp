using System;

namespace Delegate3

//デリゲートを独立したスレッドで処理する
//処理に時間がかかるメソッドでは実行中に他の処理を同時並行的に実行中できれば処理が終わるまでの間、
//プログラムが無反応にならずに済む

//作っては見たものの.NETCoreはBeginInvokemをサポートしていない模様。動きません。
//VisualStudioで動かしても同じ結果でした


{
    delegate void Del(string msg);

    class Class1{

        //時間がかかるメソッド　これを非同期で実行させる
        internal void ShowMsg(string msg){
            Console.WriteLine(msg);
            System.Threading.Thread.Sleep(5000);
        }
    }
    class  Class2{
        internal Del DelDisp;
        internal IAsyncResult DelegateCall(){
            IAsyncResult procRresult = DelDisp.BeginInvoke("デリゲート実行中",
            new AsyncCallback(CallMethod),
            null);

            return procRresult;
        }
        internal void CallMethod(IAsyncResult par){
            Del DelegateRun = (Del)par.AsyncState;
            DelegateRun.EndInvoke(par);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();
            obj2.DelDisp = new Del(obj1.ShowMsg);
            IAsyncResult during = obj2.DelegateCall();
            while (!during.IsCompleted){
                System.Threading.Thread.Sleep(500);
                Console.Write(">");
            }
            Console.WriteLine("処理が終了しました");
        }
    }
}
