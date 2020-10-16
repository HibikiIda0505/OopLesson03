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
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);  //問題7.1.1

        }

        static void Exercise1_1(string text)
        {
            var dict = new SortedDictionary<char, int>();
            //foreachで一文字ずつ取り出す
            foreach (var ch in text)
            {
                char upc = char.ToUpper(ch);
                //(半角アルファベットか調べる処理)
                //大文字へ変換
                //if ('A' <= char && char <= 'Z') {   //chは文字列型
                //     keyに存在するか？
                //     ・存在する
                //          対応するValueの値をインクリメント
                //     ・存在しない
                //          単語をkeyへ登録してValueに1を設定
                //}
                if ('A' <= upc && upc <= 'Z')
                {
                    if (dict.ContainsKey(upc))          
                    {
                        //既に登録済み
                        dict[upc]++;
                    }
                    else
                    {
                        //未登録
                        dict[upc] = 1;
                    }
                }
            }
            //累計が完了したらテキストの出力例を参考に出力して終了
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }
}
