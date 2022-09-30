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
static void Second()
            {
                Console.WriteLine("Enter a positive value: ");
                string variable = Console.ReadLine();
                string variable2 = Console.ReadLine();

                if (crisis(variable) && crisis(variable2))
                {
                    int num = int.Parse(variable);
                    int num2 = int.Parse(variable2);
                    int[] Comings = new int[num];
                    string result = ("Among the numbers you entered, these are the numbers that can be divisible by" + " " + variable2 + " are these:");
                    for (int i = 0; i < num; i++)
                    {
                        Console.WriteLine("Enter the {0}. number: ", i + 1);
                        Comings[i] = Convert.ToInt32(Console.ReadLine().Trim());
                    }
                    foreach (var item in Comings)
                    {
                        if (item % num2 == 0)
                        {
                            result = result + " " + item;
                        }
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }
}
