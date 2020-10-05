using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Jackdaws love my big sphinx of quartz";
            var lines = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            #region 問題5.1
            //Console.Write("文字列１：");
            //var s1 = Console.ReadLine();

            //Console.Write("文字列２：");
            //var s2 = Console.ReadLine();

            //if (String.Compare(s1,s2,ignoreCase:true) == 0)
            //{
            //    Console.WriteLine("等しい");
            //}
            //else
            //{
            //    Console.WriteLine("等しくない");
            //}
            #endregion

            #region 問題5.2
            //Console.Write("数値文字列：");
            //var line = Console.ReadLine();
            //int num;    //変換後の数値格納用
            //if (int.TryParse(line, out num))
            //{
            //    //Console.WriteLine("{#,#}", num);
            //    //Console.WriteLine($"{num:#,#}");
            //    Console.WriteLine(num.ToString("#,#"));
            //}
            //else
            //{
            //    Console.WriteLine("数値文字列ではありません");
            //}
            #endregion

            #region 問題5.3
            Console.WriteLine("--- 5.3.1 ---");
            int spaces = text.Count(c => c == ' ');
            Console.WriteLine("空白数:{0}",spaces);

            //5.3.2
            Console.WriteLine("--- 5.3.2 ---");
            var replaced = text.Replace("big","small");
            Console.WriteLine(replaced);

            //5.3.3
            Console.WriteLine("--- 5.3.3 ---");
            int count = text.Split(' ').Count();
            //int count = text.Split(' ').Length;
            Console.WriteLine("単語数:{0}",count);

            //5.3.4
            Console.WriteLine("--- 5.3.4 ---");
            var words = text.Split(' ')
                            .Where(s => s.Length <= 4);
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            //以下の方法でもOK(ListにしてForEachメソッドを利用)
            //text.Split(' ')
            //    .Where(s => s.Length <= 4)
            //    .ToList()
            //    .ForEach(Console.WriteLine);

            //5.3.5
            Console.WriteLine("--- 5.3.5 ---");
            var array = text.Split(' ')
                            .ToArray();
            if (array.Length > 0)
            {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1))
                {
                    sb.Append(' ');
                    sb.Append(word);           
                }
                Console.WriteLine(sb);
            }
            #endregion

            #region 問題5.4
            Console.WriteLine("--- 5.4 ---");

            foreach (var item in lines.Split(';'))
            {
                var word = item.Split('=');
                Console.WriteLine("{0}:{1}",ToJapanese(word[0]),word[1]);
            }
            #endregion
        }

        static string ToJapanese(string key)
        {
            switch (key)
            {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
                default:
                    return "    ";
            }
        }
    }
}
