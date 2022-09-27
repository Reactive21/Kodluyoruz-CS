using System;

namespace hata_yonetimi
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz Sayi: " + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("Islem Tamamlandi.");
            }
        }   
    }
}
