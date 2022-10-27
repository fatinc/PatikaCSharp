using System;

namespace MethodOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Out Parametler

            string sayi = "100";
            
            bool sonuc = int.TryParse(sayi, out int outSayi);

            if (sonuc)
            {
                Console.WriteLine("OKEY");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("NO");
            }
            
            Metotlar aa = new Metotlar();
            aa.Topla(2, 3, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            // Metot Aşırı Yükleme
            int ifade = 999;
            aa.EkranaYazdir(Convert.ToString(ifade));
            aa.EkranaYazdir(ifade);
            aa.EkranaYazdir("20", "22");
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b , out int toplam)
        {
            toplam = a + b;

        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1 , string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}