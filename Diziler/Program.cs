using System;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string gun1 = "Pazartesi";
            //string gun2 = "Salı";
            //string gun3 = "Çarşamba";
            //string gun4 = "Perşembe";
            //string gun5 = "Cuma";
            //string gun6 = "Cumartesi";
            //string gun7 = "Pazar";

            //string bugün = "Pazar";

            //if (bugün == "Cumartesi" || bugün== "Pazar")
            //{
            //    Console.WriteLine("Bugün Hafta Sonu");
            //}
            //else
            //{
            //    Console.WriteLine("Hafta İçi");
            //}

            //Console.WriteLine("**************");

            //string[] gunler; // Kullanışsız tanımlama;

            //string[] gunler = new string[7]; // array - diziler
            //gunler[0] = "pazartesi";
            //gunler[1] = "salı";
            //gunler[2] = "çarşamba";
            //gunler[3] = "perşembe";
            //gunler[4] = "cuma";
            //gunler[5] = "cumartesi";
            //gunler[6] = "pazar";

            //string[] gunler = new[] {"Pazartesi","Salı","Çarşamba","Perşembe","Cuma"};

            //Console.WriteLine(gunler.Length);

            //for (int i = 0; i < gunler.Length; i++)
            //{
            //    Console.WriteLine(gunler[i]);
            //}

            

            string[] aylar = new string[12];
            aylar[0] = "Ocak";
            aylar[1] = "Şubat";
            aylar[2] = "Mart";
            aylar[3] = "Nisan";
            aylar[4] = "Mayıs";
            aylar[5] = "Haziran";
            aylar[6] = "Temmuz";
            aylar[7] = "Ağustos";
            aylar[8] = "Eylül";
            aylar[9] = "Ekim";
            aylar[10] = "Kasım";
            aylar[11] = "Aralık";

            foreach (var ay in aylar)
            {
                if (ay == "Ocak" || ay=="Şubat" || ay=="Mart")
                {
                    Console.WriteLine("Mevsim Kış.");
                }
                else if (ay=="Nisan" || ay=="Mayıs" || ay=="Haziran")
                {
                    Console.WriteLine("Mevsim İlkbahar");
                }
            }


            //foreach (var gun in gunler)
            //{
            //    if (gun == "Cumartesi" || gun=="Pazar")
            //    {
            //        Console.WriteLine(gun+ " " + "Hafta Sonu");
            //    }
            //    else
            //    {
            //        Console.WriteLine(gun + " " + "Hafta İçi");
            //    }
            //}


            #region Sınırlılıklar
            // Diziler oluşturulurken eleman sayısını vermek zorundayız.
            // Dizilerde eleman sayısı başta belirlediğimizden, bellekte o kadar eleman olmasada, belirlenen eleman sayısı kadar yer ayrılır ve performans kayıplarına yol açabilir.


            #endregion

            #region Dizi Tanımlama

            int[] Yaslar = new int[25];
            //string[] Isimler = new string[25];

            #endregion

            #region Deger Atama

            Yaslar[3] = 18;
            Yaslar[4] = 19;

            #endregion

            #region Değer Okuma

            //Console.WriteLine(Yaslar[3]);
            //Console.WriteLine(Yaslar[4]);

            #endregion

            #region Döngü ile değer içinde dönme

            //for (int i = 0; i < Yaslar.Length; i++)
            //{
            //    Console.WriteLine(Yaslar[i]);
            //}

            #endregion

            #region Tanımlama Varyasyonları

            int[] x = new[] { 12, 5, 32, 2, 34, 56, 74 };
            int[] y = { 12, 34, 56 };
            int[] z = new int[3] { 3, 2, 1 };

            #endregion

            #region Array Sınıfı Özellikleri

            int[] Sayilar = new int[5];
            Sayilar[0] = 21;
            Sayilar[1] = 12;
            Sayilar[2] = 13;
            Sayilar[3] = 25;
            Sayilar[4] = 16;

            //Console.WriteLine("*** IsFixedSize ***");
            //// IsFixedSize dizinin eleman sayısının sabit bir değer olduğunu bool türünden döndürür.
            //Console.WriteLine(Sayilar.IsFixedSize);

            //Console.WriteLine("*** IsReadOnly ***");
            //// IsReadOnşy dizinin elemanlarının sadece okunan türde olup olmadığını bool türünde döndürür.
            //Console.WriteLine(Sayilar.IsReadOnly);

            //Console.WriteLine("*** Length ***");
            //// Length özelliği dizini boyutunu bize int türünde döndürür.
            //Console.WriteLine(Sayilar.Length);


            #endregion

            #region Metotlar

            #region Copy

            //Console.WriteLine("*** Copy Metodu ***");
            //Console.WriteLine();
            //Console.WriteLine("*** Sayılar Dizisi ***");
            ////Copy : Bir dizi elemanlarını diğer bir diziye kopyalamak için kullanılan bir metotdur.
            //for (int i = 0; i < Sayilar.Length; i++)
            //{
            //    Console.WriteLine(Sayilar[i]);
            //}

            //int[] Sayilar2 = new int[3];
            //Array.Copy(Sayilar,Sayilar2,3);

            //Console.WriteLine("*** Sayılar2 Dizisine 3 eleman kopyalanmış hali. ***");
            //for (int i = 0; i < Sayilar2.Length; i++)
            //{
            //    Console.WriteLine(Sayilar2[i]);
            //}

            #endregion

            #region IndexOf

            //// Dizi içinde harf yada kelime aramamıza yarar. Eğer harf yada kelimeyi bulursa, bulduğu ilk indexi gönderir. Bulamazsa geriye -1 gönderir.
            //Console.WriteLine("*** IndexOf metodun dan dönen değer");
            //Console.WriteLine(Array.IndexOf(Sayilar2,13));

            #endregion

            #region Reverse

            //// Dizi elemanlarını ters çevirmeye yarar.

            //for (int i = 0; i < Sayilar.Length; i++)
            //{
            //    Console.WriteLine(Sayilar[i]);
            //}

            //Console.WriteLine("*************");

            //Array.Reverse(Sayilar);

            //for (int i = 0; i < Sayilar.Length; i++)
            //{
            //    Console.WriteLine(Sayilar[i]);
            //}

            #endregion

            #region Sort

            //for (int i = 0; i < Sayilar.Length; i++)
            //{
            //    Console.WriteLine(Sayilar[i]);
            //}

            //Console.WriteLine("****************");

            //Array.Sort(Sayilar);
            //for (int i = 0; i < Sayilar.Length; i++)
            //{
            //    Console.WriteLine(Sayilar[i]);
            //}

            #endregion

            #endregion

            #region Örnekler

            //string[] gunler = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            //foreach (var gun in gunler)
            //{
            //    Console.WriteLine(gun);
            //}

            //Console.WriteLine("******************");

            //for (int i = 0; i < gunler.Length; i++)
            //{
            //    Console.WriteLine(gunler[i]);
            //}


            #endregion


        }
    }
}
