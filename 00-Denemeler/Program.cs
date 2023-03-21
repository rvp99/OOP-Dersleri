using System;
using System.Collections.Generic;

namespace _00_Denemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sinif> Liste = new List<Sinif>
            {
                new Sinif(){No = 12,Name = "Serkan",LastName = "Alsabeyit"},
                new Sinif(){No = 23,Name = "Derya",LastName = "Alsabeyit"}
            };

            Console.WriteLine(Liste[0].No);
        }

        public class Sinif
        {
            public int No { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }

        }
    }
}
