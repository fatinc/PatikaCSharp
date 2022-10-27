using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   // Kontrol edilecek Kod
                Console.WriteLine("Bir Sayı Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı:" + sayi);

            }
            catch (Exception ex)
            {   // Hata Yakalanınca ne yapılacak
                Console.WriteLine("Hata:"+ ex.Message);

            }
            finally
            {   // öd
                Console.WriteLine("İşlem Tamamlandı");
            }

            try
            {
                //int a = int.Parse(null);
                //int b = int.Parse("test");
                int c = int.Parse("-200000000000000000000");


            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex);
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex);
            }
        }
    }

}