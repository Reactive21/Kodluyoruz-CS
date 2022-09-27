using System;

namespace switchcase
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int min = DateTime.Now.Minute;
            Console.WriteLine("Enter a num:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(min);
            }
            int TekToplam = 0;
            int CiftToplam = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 1)
                    TekToplam += i;
                else
                    CiftToplam += i;
            }
            
            Console.WriteLine("TekToplam is: " + TekToplam);
            Console.WriteLine("CiftToplam is: " + CiftToplam);
            
            for(int i = 0; i < 10; i++)
            {
                if (i == 8)
                    break;
                Console.WriteLine(i);
            }
            
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}
