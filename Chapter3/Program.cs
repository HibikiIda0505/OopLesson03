using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>{
               "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
           };

            //3.2.1
            Console.WriteLine();    //改行
            Console.WriteLine("\n----- 3.2.1 -----");
            Console.WriteLine("都市名を入力。空行で終了");
            do
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) {
                    break;
                }
                var index = names.FindIndex(s => s == line);
                Console.WriteLine(index);
            } while (true);

            //3.2.2
            Console.WriteLine("\n----- 3.2.2 -----");
            var count = names.Count(s => s.Contains('o'));
            Console.WriteLine(count);

            //3.2.3
            Console.WriteLine("\n----- 3.2.3 -----");
            var selected = names.Where(s => s.Contains('o')).ToArray();
            foreach (var name in selected){
                Console.WriteLine(name);
            }

            //3.2.4
            Console.WriteLine("\n----- 3.2.4 -----");
            var nameCounts = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var length in nameCounts){
                Console.WriteLine(length);
            }

        }
    }
}
