using System;

namespace foreach_while
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Lutfen bir sayi giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayac);

            char character = 'a';
            while(character <= 'z')
            {
                Console.WriteLine(character + "\n");
                character++;
            }    
            
            string[] cars = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach(string item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
