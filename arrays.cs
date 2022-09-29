using System;

namespace arrays
{
    class proje3
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "köpek", "fil", "zebra" };
            int[] dizi;
            dizi = new int[5];

            renkler[0] = "mavi";

            Console.WriteLine(hayvanlar[1]);

            dizi[3] = 123;
            dizi[2] = 12;
            dizi[1] = 1214;
            Console.WriteLine(dizi[35]);


            Console.WriteLine("Dizi buyuklugu?: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Istediginiz sayi: ");
                sayidizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var item in sayidizisi)
            {
                toplam += item;
            }
            int ortalama = toplam / diziUzunlugu;
            Console.WriteLine("Sayilarin ortalamasi: " + ortalama);

        }
    }
}
