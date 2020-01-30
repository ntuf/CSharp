using System;


namespace Delegate
{
    class Program
    {
        delegate void Del();
        static void Disp(){
            Console.WriteLine("Hello,World!");
        }

        static void a (Del call){
            call();
        }

        static void b (Action call){ 
            call();
        }

        static void Main(string[] args)
        {
            //デリゲート経由のメソッドの呼び出し
            a(Disp);

            //定義ずみのデリゲート型使う
            b(Disp);
            
            //デリゲート型変数を利用した場合
            Action act = Disp;
            act();

            //ラムダ式による呼び出し
            //メソッドの呼び出しを分ける必要がなければデリゲート名だけを呼び出したほうがメソッドの名前が不要になる、すっきする
            Action act2 = () => {
                //ラムダ式の書き方   Action<int,int> act = (a,b) =>
                // a,bはint型の引数（パラメータ）を意味する
                Console.WriteLine("Hello,world!");
            };
            act2();

            //値を返すラムダ式
            Func<int,double,double> func = (x,y) => (x * y);
            //引数が二つなのになぜ３つの型宣言が必要なのか？これは戻り値の宣言っぽい
            int i = 100;
            double d = 3.14159;
            //デリゲートメソッドfuncでメソッド実行
            double result = func (i,d);
            Console.WriteLine(result);
        

            //Funcデリゲートを使う
            // Output output = new Output();
            // Func<bool> methodCall = output.booleRandomize();
            // if (methodCall()){
            //     Console.WriteLine("1です");
            // }else{
            //     Console.WriteLine("0です");
            // }
                
        }
    }

    // class Output{
    //     //
    //     public bool booleRandomize() {
    //         Random r1 = new System.Random(); 
    //         return r1.Next(0,1) < 0 ;
    //     }
    // }


}


