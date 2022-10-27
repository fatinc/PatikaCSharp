using System;

namespace IfElseElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if (time<11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (time<18)
            {
                Console.WriteLine("İyi Günler");
            }else
            {
                Console.WriteLine("İyi Akşmalar");
            }

            string sonuc = time <= 18 ? "İyi Günler" : "İyi Akşamlar";
            Console.WriteLine(sonuc);

            string sonuc2 = time >= 6 && time < 11 ? "Günaydın" : time <=18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc2);

        }
    }

}