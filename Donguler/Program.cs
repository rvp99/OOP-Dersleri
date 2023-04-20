using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("Merhaba");
            //}

            //for (int i = 0; i < 10; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //Diziler - Array

            string isim = "Serkan";
            string kursiyer1 = "Ali";
            string kursiyer2 = "Kemal";

            string[] gunler = {"Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar" };

            //Console.WriteLine(gunler[1]);

            foreach (var gun in gunler)
            {
                Console.WriteLine(gun);
            }

            Console.WriteLine("**************");

            //for (int i = 0; i <= 6; i++)
            //{
            //    Console.WriteLine(gunler[i]);
            //}

            for (int i = 0; i < gunler.Length; i++)
            {
                Console.WriteLine(gunler[i]);
            }


            //for (int i = 0;i<=10;i+=2)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("****************");

            Console.ReadLine();


            // ********* While ve Do-While döngüsü


            //while (a = 10)
            //{
            //    // Yapılacak işler
            //}

            // 
            // Do - While döngüsü



        }
    }
}
