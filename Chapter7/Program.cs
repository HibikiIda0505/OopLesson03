using Section02;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************");
            Console.WriteLine("* 辞書登録プログラム *");
            Console.WriteLine("**********************");

            Console.WriteLine("1．登録 2．内容を表示");

        }

        static public void DuplicateKey()
        {
            // ディクショナリの初期化
            var dict = new Dictionary<string, List<string>>() {
               
            };

            // ディクショナリに追加
            Console.Write("KEYを入力：");
            var key = Console.ReadLine();

            Console.Write("VALUEを入力：");
            var value = Console.ReadLine();

            if (dict.ContainsKey(key))
            {
                dict[key].Add(value);
            }
            else
            {
                dict[key] = new List<string> { value };
            }
            Console.WriteLine("登録しました！");

            // ディクショナリの内容を列挙
            foreach (var item in dict)
            {
                foreach (var term in item.Value)
                {
                    Console.WriteLine("{0} : {1}", item.Key, term);
                }
            }
        }
    }
}
