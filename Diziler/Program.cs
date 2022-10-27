using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Dizi Tanımlama

            //string[] colors = new string[5];

            //string[] animals = { "cat", "dog", "fish", "horse", "mouse" };

            //int[] dizi;

            //dizi = new int[5];

            //// Dizilere Değer Atama ve Erişim

            //colors[0] = "Blue";

            //Console.WriteLine(colors[0]);

            //dizi[3] = 10;

            //Console.WriteLine(animals[3]);
            //Console.WriteLine(dizi[3]);


            //// Döngüler ile Dizi Kullanımı

            //// Klavyeden girilen n tane sayının ortalaması

            //Console.WriteLine("Lütfen Dizinin Eleman Sayısını Giriniz:");
            //int diziuzunlugu = int.Parse(Console.ReadLine());
            //int[] sayiDizisi = new int[diziuzunlugu];

            //for (int i = 0; i < diziuzunlugu; i++)
            //{
            //    Console.Write("Lütfen Dizinin {0}. saysısını giriniz:", i + 1);
            //    sayiDizisi[i] = int.Parse(Console.ReadLine());

            //}
            //int toplam = 0;
            //foreach (var sayi in sayiDizisi)
            //{
            //    toplam += sayi;
            //}

            //Console.WriteLine(toplam/diziuzunlugu);


            ArrayClass();

        }

        public static void ArrayClass()
        {
            Console.WriteLine("---------sırasız---------");
            int[] sayiDizisi = { 23, 12, 15, 16, 12 };

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Sıralı dizi yapma 

            Console.WriteLine("---------sıralı---------");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Clear
            Console.WriteLine("---------2. ve 3. Eleman 0 ---------");
            Array.Clear(sayiDizisi, 1, 2);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Reverse
            Console.WriteLine("---------Reverse ---------");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            // Reverse
            Console.WriteLine("---------IndexOf ---------");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize
            Console.WriteLine("---------Resize ---------");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 789;
            sayiDizisi[7] = 9;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

        }
    }

}