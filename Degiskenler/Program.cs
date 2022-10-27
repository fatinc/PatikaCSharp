using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger;
            deger = 2;
            Console.WriteLine(deger);
            String degisken = " ";
            Console.WriteLine(degisken);

            string str1 = "Fikrican";
            String str2 = "Atınç";
            string str3 = str1 + str2;
            string kullanici = str1 + " " + str2;
            Console.WriteLine(kullanici);
            Console.WriteLine(str3);

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            int count1 = 5;
            int count2 = 2;
            int carpim = count1 * count2;
            Console.WriteLine(carpim);

            bool bool1 = 10 > 2;
            Console.Write(bool1);


            string str10 = "20";
            int int10 = 10;

            string newvalue = str10 + int10.ToString();
            Console.WriteLine(newvalue);

            int int20 = int10 + Convert.ToInt32(str10);
            Console.WriteLine(int20);




            Console.ReadLine();

        }
    }

}
