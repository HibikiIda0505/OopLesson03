using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args){
            //4.2.1
            var ymCollection = new YearMonth[]{
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,7),
                new YearMonth(2010,9),
                new YearMonth(2020,12),
            };

            //4.2.2
            Console.WriteLine("-- 4.2.2 --");
            Exercize2_2(ymCollection);
            Console.WriteLine("-----------");

            //4.2.3
            Console.WriteLine("-- 4.2.3 --");
            Console.WriteLine(FindFirst21C(ymCollection));
            Console.WriteLine("------------\n");

            //4.2.4(呼び出し)
            Console.WriteLine("-- 4.2.4 --");
            Exercize2_2(ymCollection);
            Console.WriteLine("------------\n");

            //4.2.5(呼び出し)
            Console.WriteLine("-- 4.2.5 --");
            Exercize2_2(ymCollection);
            Console.WriteLine("------------\n");

        }
        private static void Exercize2_2(YearMonth[] ymCollection){
            foreach (var ym in ymCollection){
                Console.WriteLine(ym);
            }
        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms){
            foreach (var ym in yms){
                //21世紀ならreturnして終了
                if (ym.Is21Century)
                    return ym;
                }
                //21世紀が存在しなければnullを返却
                return null;
            }

        //4.2.4
        private static void Exercize2_4(YearMonth[] ymCollection){
            var yearmonth = FindFirst21C(ymCollection);
#if false
            var s = yearmonth == null ? "21世紀のデータはありません" : yearmonth.ToString();
            Console.WriteLine(s);
#else
            if(yearmonth == null)
               Console.WriteLine("21世紀のデータはありません");
            else
               Console.WriteLine(yearmonth);
#endif
        }

        //4.2.5
        private static void Exercize2_5(YearMonth[] ymCollection){
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in array){
                Console.WriteLine(ym);
            }
        }
    }
}
