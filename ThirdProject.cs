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
            static void Third()
            {
                Console.WriteLine("Enter a positive value: ");
                string variable = Console.ReadLine();

                if (crisis(variable))
                {
                    int num = int.Parse(variable);
                    string[] words = new string[num];
                    for (int i = 0; i < num; i++)
                    {
                        Console.WriteLine("Enter the {0}. number: ", i + 1);
                        words[i] = Console.ReadLine().Trim();
                    }
                    Array.Reverse(words);
                    foreach (var item in words)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
