using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //値の入出力
            //問題１
            Console.WriteLine("ntuf!");

            //問題２
            string s = Console.ReadLine();
            Console.WriteLine(s);

            //組込み演算子
            //問題1
            int a = 2;
            int b = 3;
            Console.WriteLine("2+3=" + (a + b));
            Console.WriteLine("2-3=" + (a - b));
            Console.WriteLine("2*3=" + (a * b));
            Console.WriteLine("2/3=" + (a / b));

            //問題2
            double da = 2;
            double db = 3;
            Console.WriteLine("2+3=" + (da + db));
            Console.WriteLine("2-3=" + (da - db));
            Console.WriteLine("2*3=" + (da * db));
            Console.WriteLine("2/3=" + (da / db));

            //問題3
            //複素数がわからないので

            //問題4
            Console.WriteLine("半径の長さを入力してください");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine(radius * 3.14 );

            //問題5
            Console.WriteLine("身長と体重を入力してください");
            double height = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            double bmi = weight / ( height * height);
            if (bmi < 19.8){
                Console.WriteLine("痩せ型");
            }else if(19.8 <= bmi && bmi < 24.2){
                Console.WriteLine("普通");
            }else if(24.2 <= bmi && bmi  < 26.4){
                Console.WriteLine("やや肥満（過体重）");
            }else if(26.4 <= bmi && bmi  < 35.0){
                Console.WriteLine("肥満");
            }else if(35.0 < bmi){
                Console.WriteLine("高度肥満（要治療）");
            }

            //組み込み型変換
            //問題1
            var chr ='a';
            Console.WriteLine("文字 {0} の文字コードは {1}\n", chr, (int)chr);
            
            //
            Console.WriteLine("連択");







            



            


        }
    }
}
