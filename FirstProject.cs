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
            static void First()
            {
                Console.WriteLine("Enter a positive value:");
                string variable = Console.ReadLine();
                if (crisis(variable))
                {
                    int variable2 = int.Parse(variable);
                    int[] Comings = new int[variable2];

                    for (int i = 0; i < variable2; i++)
                    {
                        Console.WriteLine("Enter the {0}. number: ", i + 1);
                        Comings[i] = Convert.ToInt32(Console.ReadLine().Trim());
                    }
                    Console.WriteLine("\n Even numbers are:");
                    for (int j = 0; j < Comings.Length; j++)
                    {
                        if (Comings[j] % 2 == 0)
                        {
                            Console.Write(Comings[j] + ", ");
                        }

                    }
                }
            }
        }
    }
}
