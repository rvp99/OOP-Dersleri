using System;
using System.Security.Cryptography;

namespace Metotlar
{
    internal class Program
    {
        #region Metot nedir?

        //Yapacağımız uygulama içerisinde bölümlere, kendi içerisinde küçük parçalara ayrılarak oluşturulan ve sonradan çağırılma amacı ile kullanılabilen kod satırları olarak "Metot Nedir?" sorusuna basit bir tanım yapabilirim. Metotlar, programlarımız için esneklik sağladıklarının yanı sıra, sürekli aynı kod satırlarını tekrar etmemizin önüne geçmektedir.

        #endregion

        #region Metot tanımlama

        // Metot tanımlama yapılırken ilk önce "Erişim Belirteci" dediğimiz (static,public,private vs.) başlıyoruz. Daha sonra dönüş tipimizi belirtiyoruz. (void, int,string vs.). Daha sonra da metodumuza isim veriyor, parantezlerimizi açıp kapayarak süslü parantezlerimiz ile tanımlamamızı bitiriyoruz.


        static void Topla()
        {
            Console.WriteLine(2 + 3);
        }

        #endregion

        #region Metot Türleri

        // C# da iki türde metot bulunmaktadır.
        // 1- Geriye değer döndürmeyen metotlar.
        // 2- Geriye değer döndüren metotlar.(Parametre alan da denilebilir.)

        #endregion

        #region Geriye Değer Döndürmeyen Metotlar

        // Geriye değer döndürmeyen metotlar kendi scope larında yazılmış olan kod bloklarını çalıştırır ve scope içi yapılması gereken işler tamamlanınca geriye bir değer döndürmezler. Karateristik olarak parametre alabilir yada gerek yok ise parametre almadan işlerini yaparlar.

        static void Marka()
        {
            Console.WriteLine("Roxis Teknoloji");
        }

        static void Topla(int a, int b)
        {
            Console.WriteLine("Girilen sayıların toplamı: " + (a + b));
        }

        static void Name(string name)
        {
            Console.WriteLine("Adınız: " + name);
        }

        #endregion

        #region Geriye Değer Döndüren Metotlar

        // Geriye değer döndüren metotlar kendi scope larının içinde yapılması gereken işlemeleri yaptıktan sonra metot dışına yaptığı işlemlerin sonucunu çıkaran metotlardır. Biz genel olarak geriye değer döndüren metotları işlemlerin sonuç değerleri ile ilgilendiğimiz zamanlarda kullanırız.

        //Geriye değer döndüren metotlarda void kelimesi kullanılmaz ve geriye dönecek olan değerin türü dikkate alınarak metot oluşturulur.

        static int ToplamaYap(int a, int b)
        {
            int sonuc = a + b;
            return sonuc;
        }


        // Return anahtar kelimesinin metot içinde 2 ana görevi vardır.
            // 1- İşlem sonucunda oluşa değerleri geriye döndürür.
            // 2- Metot u bitiren anahtar kelimedir.

            #endregion

            #region Örnek

            //static int KareAl(int a)
            //{
            //    return a * a;
            //}

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());

            //int sonuc = KareAl(sayi);

            //    if (sonuc > 25)
            //{
            //    Console.WriteLine("Girilen sayı: " +sayi+ " " +"Karesi: " + sonuc);
            //    Console.WriteLine("Karesi 25'den büyüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı: " + sayi + " " + "Karesi: " + sonuc);
            //    Console.WriteLine("Karesi 25'den küçüktür.");
            //}

            #endregion

            static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());

            int sonuc = Kare(sayi);

            if (sonuc < 25)
            {
                Console.WriteLine("Girilen Sayı: " + sayi +"Karesi: " + sonuc);
                Console.WriteLine("Sonuc 25 de küçüktür");
            }
            else
            {
                Console.WriteLine("Girilen Sayı: " + sayi + "Karesi: " + sonuc);
                Console.WriteLine("Sonuc 25 den büyüktür");
            }

        }


        //static void Topla()
        //{
        //    Console.WriteLine(2+9);
        //    Console.WriteLine("Toplama işlemi sonuçlandı.");
        //}

        //static void Toplama(int a, int b)
        //{
        //    Console.WriteLine(a + b);
        //}

        //static void IsimSoyisim(string isim, string soyisim)
        //{
        //    Console.WriteLine(isim +" "+ soyisim);
        //}

        //static decimal Toplama(decimal a, decimal b)
        //{
        //    return a / b;
        //}

        static int Kare(int a)
        {
            Console.WriteLine("Girilen sayının karesi alınıyor.");
            return a * a;
            Console.WriteLine("Metot bitmiştir.");
        }
    }
}
