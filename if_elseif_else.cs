using System;

namespace if_elseif
{
    class Program
    {
        public static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            if (hour >= 6 && hour <= 18)
                Console.WriteLine("Good Morning!");
            else if (hour >= 18)
                Console.WriteLine("Good Day!");
            else
                Console.WriteLine("Good Night!");


            string sonuc = hour <= 18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);
        }
    }
}
