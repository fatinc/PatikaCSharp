using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            // ----------------------- Genel Yapı --------------------------------
            // erişim_belirteci  geri_donusTipi metot_adi(parametreListesi/arguman)
            //{
            //  Komutlar
            //}

            int a = 2;
            int b = 3;
            int sonuc = a + b;
            Console.WriteLine(a + b);

            Console.WriteLine(Topla(a, b));

            Metotlar aa = new Metotlar();
            aa.PrintScreen(Convert.ToString(sonuc));
            int sonucx = aa.ArttırVeTopla(a, b);
            Console.WriteLine("gelen "+sonucx);
           
        }

       
        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }

       
    }

    class Metotlar
    {
        public void PrintScreen(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(int deger1 , int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }

}