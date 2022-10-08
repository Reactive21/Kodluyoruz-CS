using System;
using System.Collections.Generic;
using System.Collections;

namespace Collections_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arlist = new ArrayList();
            for(int i = 0;i<20;i++)
            {
                Console.WriteLine("Enter the {0}th element: ", i + 1);
                int t;
                bool express = Int32.TryParse(Console.ReadLine(), out t);
                if(express)
                {
                    arlist.Add(t);
                }
                else
                {
                    Console.WriteLine("Please enter a positive value.");
                    i -= 1;
                    continue;
                }
            }
            arlist.Sort();

            float x = Convert.ToInt32(arlist[0]);
            float y = Convert.ToInt32(arlist[1]);
            float z = Convert.ToInt32(arlist[2]);

            float a = Convert.ToInt32(arlist[17]);
            float b = Convert.ToInt32(arlist[18]);
            float c = Convert.ToInt32(arlist[19]);

            float smallmean = (x + y + z) / 3;
            float bigmean = (a + b + c) / 3;

            Console.WriteLine("Mean of big numbers is: " + bigmean);
            Console.WriteLine("Mean of small numbers is: " + smallmean);
        }
    }
}
