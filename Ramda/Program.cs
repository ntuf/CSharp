using System;
using System.Collections.Generic;

namespace Ramda
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
            // ここで、受験者全員の数学の平均点を求めたい
            double mathAve = CalcMathAverage(results);
            Console.WriteLine(mathAve);
        }

        /// <summary>
        /// 受験者全員の数学の平均点を求めるメソッド
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        static double CalcMathAverage(List<TestResult> results)
        {
            double ans = 0;
            foreach (TestResult tr in results)
            {
                double num = tr.Math;
                ans += num;
            }
            ans /= results.Count;
            return ans;
        }
            // では、同様に物理の点数の平均点を求めるメソッドはどのようにして作ればよいでしょうか？
            // double num = tr.Physics;以外の行は数学の平均点を求めるメソッドと全く同じです。
            // また、今後科目数が増えると、その都度コピペしてメソッドを追加するのでしょうか？
            // もしこのメソッドに修正が入った場合、コピペした全てのメソッドを修正しますか？
            // そんな事はしたくないですよね。
            // 何かいい方法はないでしょうか・・・
            // そんな時に使えるのが「デリゲート」です。
            // この「デリゲート」を引数にすることによって、メソッド内部のロジックを外から変更する事が可能になります。
            // →Ramda2を参照すること
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