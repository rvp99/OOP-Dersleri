using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Soru - 1

            /*
            Verilen sayı eğer 0 ve 100 aralığındaysa ekrana “Sayı 0 ile 100 aralığındadır.”, eğer 100 ve 200 aralığındaysa ekrana “Sayı 100 ile 200 aralığındadır.”, eğer sayı 0’dan küçük veya 200’den büyükse de “Sayı 0’dan küçük veya 200’den büyüktür.” yazdırın.
            */


            int sayi = 20;

            if (sayi >= 0 && sayi <= 100) // Sayi o ve büyükse ve 100 ve küçükse
            {
                Console.WriteLine("Sayı 0 ile 100 aralığındadır.");
            }
            else if (sayi >= 100 && sayi <= 200)
            {
                Console.WriteLine("Sayı 100 ile 200 aralığındadır.");
            }
            else if (sayi < 0 || sayi > 200)
            {
                Console.WriteLine("Sayı 0’dan küçük veya 200’den büyüktür.");
            }
            else
            {
                Console.WriteLine("Girilen sayı yanlıştır");
            }

            Console.ReadLine();

            #endregion


            #region Soru - 2

            //Klavyeden girilen mevsimde bulunan ayları ekrana yazdırınız.

            string mevsim;
            Console.Write("Bir mevsim girin: ");
            mevsim = Console.ReadLine();

            if (mevsim == "ilkbahar")
            {
                Console.WriteLine(mevsim + "mevsiminde Mart,Nisan,Mayıs ayları vardır.");
            }
            else if (mevsim == "yaz")
            {
                Console.WriteLine(mevsim + "mevsiminde Haziran,Temmuz,Ağustos ayları vardır.");
            }
            else if (mevsim == "sonbahar")
            {
                Console.WriteLine(mevsim + "mevsiminde Eylul,Ekim,Kasım ayları vardır.");
            }
            else if (mevsim == "kıs")
            {
                Console.WriteLine(mevsim + "mevsiminde Aralık,Ocak,Şubat ayları vardır.");
            }
            else
            {
                Console.WriteLine("Böyle bir mevsim yok.");
            }

            Console.ReadLine();


            #endregion


            #region Odev

            //Kullanıcıdan 3 adet sınav notu girmesini isteyin.Girilen sınav notlarının ortalaması 0 ve 50 aralığındaysa ekrana “Kaldınız”, 50 ve 100 aralığındaysa ekrana “Geçtiniz” yazdırın.Eğer bu değerler arasında değilse ekrana “Geçersiz Değer” yazdırın.

            #endregion


        }
    }
}
