using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // En sık kullanılan değişken tipleri aşağıdaki giibidir.
            // int = Tam sayı tutan değişken tipi.
            // decimal = Ondalıklı sayı tutan değişken tipi.
            // double = Ondalıklı sayı tutan değişken tipi.
            // string = Metinsel değer tutan değişken tipi.
            // char = Sadece tek harf tutabilen değişken tipi.
            // bool = True yada False değer tutan değişken tipi. (Boolen)
            // Bir değişken tanımlarken ilk olarak değişkenin tipini sonrada değişken ismini veririz. Aşağıda değişken tanımlama örneklerini görebilirsiniz.

            int x = 12;
            decimal y = 14.7M;          // Ondalıklı sayıları decimal tanımlarsak sonuna 'M' getiriyoruz.
            double z = 123.5;
            string name = "Serkan";     // Metin tipi değişkenler çift tırnak içine yazılırlar.
            char a = 'a';               // Char tipi değişkenler tek tırnak içine yazılırlar.
            bool sonuc = true;
        }
    }
}
