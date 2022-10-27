using System;

namespace Operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşelemli Atama

            int x = 3;
            int y = 4;
            int m;
            x = x + 2;
            y = y + 1;
            m = x * y;


            Console.WriteLine(m);
            Console.WriteLine(x + y);

            int a = 5;
            a += 2;

            Console.WriteLine(a);

            // Mantıksal Operatörler || veya /  && ve  /  ! değil

            bool IsSucces = true;
            bool IsCompleted = false;

            if (IsSucces || IsCompleted)
            {
                Console.WriteLine("Perfect !");
            }


            if (IsSucces && IsCompleted)
            {
                Console.WriteLine("Perfect !");
            }
            else
            {
                Console.WriteLine("Not perfect ");
            }


            if (IsSucces && !IsCompleted)
            {
                Console.WriteLine("Perfect !");
            }
            else
            {
                Console.WriteLine("Not Perfect");
            }


            // İlişkisel Operatörler <  / >  / <= / >= /  == /  !=

            int c = 6;
            int d = 8;
            bool sonuc = c < d;

            sonuc = c < d;
            Console.WriteLine(sonuc);
            sonuc = c > d;
            Console.WriteLine(sonuc);
            sonuc = c <= d;
            Console.WriteLine(sonuc);
            sonuc = c >= d;
            Console.WriteLine(sonuc);
            sonuc = c == d;
            Console.WriteLine(sonuc);
            sonuc = c != d;
            Console.WriteLine(sonuc);


            // Aritmetik Operatörler / * + - %

            int e = 10;
            int o = 10;
            int sonuc1 = e / o;
            Console.WriteLine(sonuc1);
            int sonuc2 = e % o;
            Console.WriteLine(sonuc2);
            int sonuc3 = e++;
            Console.WriteLine(sonuc3);
            int sonuc4 = o - e;
            Console.WriteLine(sonuc4);
            int sonuc5 = o * e / 100;
            Console.WriteLine(sonuc5);  


























            Console.ReadLine();
        }
    }

}