using System;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif Öz Yineleme 3^4 = 3*3*3*3

            int a = 3;
            for (int i = 0; i < 5; i++)
            {
                a = a * 3;
                Console.WriteLine(a);
            }

            Islemler islem = new Islemler();
            Console.WriteLine(islem.Expo(3, 2));

            // Extension Metotlar
            string ifade = "fikrican atınç kuşadası";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(ifade.CheckSpaces);

            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces);
            }
            Console.WriteLine(ifade);

        }
    }

    public class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs == 0)
            {
                return 1;
            }
            else if (üs == 1)
            {
                return sayi;
            }
            else
            {
                return Expo(sayi, üs - 1) * sayi;
            }


        }
    }

    public static class Extension{

        public static bool CheckSpaces( this string param)
        {
            return param.Contains(" "); 
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);   
        }
    }
}