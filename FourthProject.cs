using System;

namespace MetodTanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool crisis(string gelenSayi)
            {
                bool sonuc = int.TryParse(gelenSayi, out int outSayi);
                if (sonuc)
                {
                    if (outSayi > 0)
                    {
                        Console.WriteLine("true");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen sadece pozitif bir sayı giriniz!");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen sadece pozitif bir sayı giriniz!");
                    return false;
                }
            }
            static void Fourth()
            {
                Console.WriteLine("Enter a positive value: ");
                string variable = Console.ReadLine().Trim();
                string[] words = variable.Split(' ');

                string result = "\n Total words you entered is: ";

                Console.WriteLine(result = result + words.Length);

                int resultLetters = 0;
                foreach(var item in words)
                {
                    resultLetters += item.Length;
                }
                Console.WriteLine("\n Total characters are that much: " + resultLetters);
            }
        }
    }
}
