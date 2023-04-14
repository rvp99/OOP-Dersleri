using System;
using System.Collections.Generic;
using System.Threading;

namespace _00_Denemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Toplama(3, 5);
            Console.WriteLine("Result: " + result);
            //Toplama(3, 5);
            Topla();

        }

        static int Toplama(int a, int b)
        {
            int sonuc = a + b;
            return sonuc;
        }

        static void Topla()
        {
            Console.WriteLine("Toplam: " + (2+3));
        }
    }
}
