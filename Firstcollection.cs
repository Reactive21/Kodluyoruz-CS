using System;
using System.Collections.Generic;
using System.Collections;

namespace Collections_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arlist = new ArrayList();
            for(int i = 0;i<20;i++)
            {
                Console.WriteLine("Enter the {0}th element: ", i + 1);
                int x;
                bool express = Int32.TryParse(Console.ReadLine(), out x);
                if(express)
                {
                    arlist.Add(x);
                }
                else
                {
                    Console.WriteLine("Please enter a positive value.");
                    i -= 1;
                    continue;
                }
            }
            var primelist = new ArrayList();
            var nonprimelist = new ArrayList();

            foreach(int item in arlist)
            {
                if(primeornot(item))
                {
                    primelist.Add(item);
                }
                else
                {
                    nonprimelist.Add(item);
                }
            }

            Console.WriteLine("Prime outputs are: ");
            primelist.Sort();
            primelist.Reverse();
            Console.WriteLine(primelist);
            makealist(primelist);
            printmean(primelist);

            Console.WriteLine("Non-Prime outputs are: ");
            nonprimelist.Sort();
            nonprimelist.Reverse();
            Console.WriteLine(nonprimelist);
            makealist(nonprimelist);
            printmean(nonprimelist);



            static bool primeornot (int num)
            {
                if (num == 1 || num== 0)
                    return false;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }
            static void makealist (ArrayList liste)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    Console.Write(liste[i] + " ");
                }
                Console.WriteLine();
            }
            static double printmean(ArrayList liste)
            {
                int toplam = 0;
                for (int i = 0; i < liste.Count; i++)
                {
                    toplam += Convert.ToInt32(liste[i]);
                }
                double ortalama = (double)toplam / liste.Count;
                return ortalama;
            }
        }
    }
}
