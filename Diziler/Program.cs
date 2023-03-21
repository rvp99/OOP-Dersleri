using System;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sınırlılıklar
            // Diziler oluşturulurken eleman sayısını vermek zorundayız.
            // Dizilerde eleman sayısı başta belirlediğimizden, bellekte o kadar eleman olmasada, belilenen eleman sayısı kadar yer ayrılır ve performans kayıplarına yol açabilir.
            

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

            for (int i = 0; i < Sayilar.Length; i++)
            {
                Console.WriteLine(Sayilar[i]);
            }

            Console.WriteLine("****************");

            Array.Sort(Sayilar);
            for (int i = 0; i < Sayilar.Length; i++)
            {
                Console.WriteLine(Sayilar[i]);
            }

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
