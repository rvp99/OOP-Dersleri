using System;

namespace _07_Sınıflar
{
    internal class Program
    {
        #region Class nedir?

        /*
         * Nesnel Programlamanın en temel özelliğidir.
         * Class ları genel olarak yapmak isteiğimiz işlemleri gruplara ayırmak, grup üzerinden işlemlerimizi yapmak ve bu gruplara ulaşmak için kullanırız.
         * Class kullanımlarında öncelikle nesne nin bir örneğini oluştururuz, daha sonrada oluşturulan örnek nesnenin altındaki metotlara ulaşırız.
         * Class kullanımında nesneler direkt main de oluşturulabildiği gibi, proje içinde ayrı bir nesne olarak da oluşturulabilir.
         */

        #endregion

        #region Class Property

        /*
         * Class ların bir diğer özelliğide property denilen özellikleri tutmaktır.
         * Property ler bir nesnenin kendi özelliklerini tutmak için kullanılırlar.
         * Property lerde değer atamak set, değeri okumak ise get olarak isimlendirilir.
         */

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("***** Class *****");
            Kitaplar kitap1 = new Kitaplar();
            kitap1.Ekle();

            Personel personel1 = new Personel();
            personel1.Isim = "Serkan";
            personel1.Soyadi = "Alsabeyit";
            personel1.Telefon = 5551112233;

            Personel personel2 = new Personel
            {
                Isim = "Ahmet",
                Soyadi = "Çolak",
                Telefon = 5556667788
            };

            Console.WriteLine(personel2.Isim +" "+ personel2.Soyadi);

        }

    }

}
