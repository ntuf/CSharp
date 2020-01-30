using System.Collections.Generic;
using System;

namespace Ramda2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TestResult> results = new List<TestResult>()
            {
                new TestResult(){ Name = "Suzuki Ichiro", Math = 80, Physics = 60 },
                new TestResult(){ Name = "Akagawa jiro", Math = 70, Physics = 90 },
                new TestResult(){ Name = "Mikawa Saburo", Math = 90, Physics = 100 },
            };
            // 受験者全員の数学の平均点を求めたい
            double mathAve = results.CalcAverage(tr => tr.Math);
            //↑ CalcAverageは拡張「メソッドなのでこれで呼べる(thisがついてる)
            //↑ 第一引数のresultsが先頭に来るため、引数は一つだけとなります
            // 
            //↑ tr => tr.Mathは、以下のメソッドと同じ意味
            //      static double funcMath(TestResult tr)
            //      {
            //          return tr.Math;
            //      }
        
            Console.WriteLine(mathAve);
        }
    }

    //ラムダ式を使いdouble型であればどんなプロパティでも平均を求められるようにし、
    //更にジェネリックを使いクラスを限定せずに様々なクラスから使用できるようにしました。

    /// <summary>
    /// 今回作成したList<T>のユーティリティクラス
    /// </summary>
    public static class ListUtil
    {
        /// <summary>
        /// 平均を求める
        /// </summary>
        /// <param name="results">平均を求めるリスト</param>
        /// <param name="func">リストのクラスから平均を求めたい要素を選択する</param>
        /// <returns>選択した要素の平均</returns>
        public static double CalcAverage<T>(this List<T> results, Func<T, double> func)
        {
            double ans = 0;
            foreach (T tr in results)
            {
                ans += func(tr);
            }
            ans /= results.Count;
            return ans;
        }
    }


    /// <summary>
    /// 受験者の氏名と試験結果のクラス
    /// </summary>
    public class TestResult
    {
        /// <summary> テストを受けた者の名前 </summary>
        public string Name { get; set; }

        /// <summary> 数学の点数 </summary>
        public double Math { get; set; }

        /// <summary> 物理の点数 </summary>
        public double Physics { get; set; }
    }

}