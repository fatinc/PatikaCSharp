using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion Bilinçsiz Dönüşüm


            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a+ b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);

            float i = h;
            Console.WriteLine(i);

            string e = "fikrican";
            char f = 'A';
            object g = e + f + d;
            Console.WriteLine(g);



            // Explicit Conversion Bilinçli Dönüşüm





            Console.ReadLine();

        }
    }

}