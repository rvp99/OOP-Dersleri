using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Channels;

namespace _00_Denemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kitap> kitaplar = new List<Kitap>();
            while (true)
            {
                Console.Clear();
                string tercih;
                
                Console.WriteLine("Kitapçı Kontrol Paneli");
                Console.WriteLine("1- Kitap Kontrol"); 
                Console.WriteLine("2- Kitap Ekle");
                Console.WriteLine("3- Kitap Sil");
                Console.Write("Lütfen işleminizi seçiniz.");
                tercih = Console.ReadLine();

                switch (tercih)
                {
                    case "1":
                        Console.WriteLine("Kitap Kontrol");
                        Listele();
                        break;
                    case "2":
                        Console.WriteLine("Kitap Ekle");
                        Ekle();
                        break;
                    case "3":
                        Console.WriteLine("Kitap Sil");
                        break;
                    default:
                        Console.WriteLine("Böyle bir seçim yok.");
                        break;
                }

                void Ekle()
                {
                    string Id;
                    string Adi, Yazar, Tur;
                    Console.Clear();
                    Console.Write("Kitap Id: ");
                    Id = Console.ReadLine();
                    Console.Write("Kitap Adı: ");
                    Adi = Console.ReadLine();
                    Console.Write("Kitap Yazarı: ");
                    Yazar = Console.ReadLine();
                    Console.Write("Kitap Türü: ");
                    Tur = Console.ReadLine();

                    Kitap EklenenKitap = new Kitap()
                    {
                        Id = Id,
                        Adi = Adi,
                        Yazar = Yazar,
                        Tur = Tur
                    };

                    kitaplar.Add(EklenenKitap);
                     
                }

                void Listele()
                {
                    Console.Clear();
                    Console.WriteLine("***** KITAPLAR *****");

                    foreach (var kitap in kitaplar)
                    {
                        
                        Console.WriteLine("Kitap Id: {0} Kitap Adı: {1} Yazar: {2}" , kitap.Id , kitap.Adi,kitap.Yazar);
                    }

                    Console.WriteLine("***** KITAPLAR *****");
                    Console.ReadLine();
                    
                }
            }

            
            
        }
    }


    class Kitap
    {
        public string Id { get; set; }
        public string Adi { get; set; }
        public string Yazar { get; set; }
        public string Tur { get; set; }
    }
}
