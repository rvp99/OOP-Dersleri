using System;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] gunler = new string[]{"Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar"};

            foreach (var gun in gunler)
            {
                Console.WriteLine(gun);
            }

            Console.WriteLine("******************");

            for (int i = 0; i < gunler.Length; i++)
            {
                Console.WriteLine(gunler[i]);
            }

        }
    }
}
