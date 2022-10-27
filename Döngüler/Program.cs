using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            Donguler1();
        }

        public static void Donguler1()
        {

            // Tek Sayıları Yazdır

            Console.WriteLine("Bir Sayı Giriniz:");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine(i);
                }

            }
            // 1 ile 100 arasındaki tek ve çift sayıların kendi arasındaki toplamı

            int TekToplam = 0;
            int ÇiftToplam = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i%2 == 1)
                {
                    TekToplam += i;
                }
                else
                {
                    ÇiftToplam += i;
                }
                
            }
            Console.WriteLine("Tek Toplam :" + TekToplam + " Çift Toplam : " + ÇiftToplam);

            // Break

            for (int i = 1; i < 10; i++)
            {
                if (i==4)
                {
                    break;
                    
                }
                Console.WriteLine(i);
            }


            // Continue

            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;

                }
                Console.WriteLine(i);
            }

        }
    }

}
