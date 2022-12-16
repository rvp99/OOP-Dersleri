using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2, toplam;
            string islem = "";
            Console.Write("Birinci sayıyı giriniz.");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz.");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Lütfen işlem türünü giriniz: ");
            islem = Console.ReadLine();

            switch (islem)
            {
                case "+":
                    toplam = sayi1 + sayi2;
                    Console.WriteLine("Sonuç" + toplam);
                    break;
                case "-":
                    toplam = sayi1 - sayi2;
                    Console.WriteLine("Sonuç" + toplam);
                    break;
                case "*":
                    toplam = sayi1 * sayi2;
                    Console.WriteLine(toplam);
                    break;
                case "/":
                    toplam = sayi1 / sayi2;
                    Console.WriteLine(toplam);
                    break;
                default:
                    Console.WriteLine("Boyle bir işlem türü yok.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
