using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-10 sayıları aradındaki çift sayıları yazdırın.
            // bunu yapmak için her sayının çift mi tekmi olduğuna bakmam lazım
            // bunun içinde döngü kulanıcam.
            // bir sayı 2 ye bölündükten sonra kalan 0 ise sayı çifttir.



            for (int i = 0;i<=10;i+=2)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
