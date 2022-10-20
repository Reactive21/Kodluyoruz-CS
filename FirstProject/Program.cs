using System;
using System.Globalization;
using System.IO.MemoryMappedFiles;
using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int secimNo = 0;
            Listers.names.Add("Mehmet");
            Listers.surnames.Add("Arslan");
            Listers.no.Add("5468568989");

            Listers.names.Add("Ayşe");
            Listers.surnames.Add("Gün");
            Listers.no.Add("5468562289");

            Listers.names.Add("Ali");
            Listers.surnames.Add("Baykar");
            Listers.no.Add("5464448989");

            Listers.names.Add("Çiğdem");
            Listers.surnames.Add("Mert");
            Listers.no.Add("546555989");

            Listers.names.Add("Gürkan");
            Listers.surnames.Add("Güçlü");
            Listers.no.Add("5468511189");

        FirstLoop:
            Console.WriteLine("Enter the operation that you want to do.");
            Console.WriteLine("1) Saving a new number.");
            Console.WriteLine("2) Deleting a new number.");
            Console.WriteLine("3) Updating a new number.");
            Console.WriteLine("4) List Phonebook.");
            Console.WriteLine("5) Search somebody from Phonebook.");

            try
            {
            SecondLoop:
                secimNo = Int32.Parse(Console.ReadLine());
                if(secimNo < 1 || secimNo>5)
                {
                    Console.WriteLine("Enter a value between 1 and 5");
                    goto SecondLoop;
                }
            }
            catch
            {
                Console.WriteLine("Enter a value between 1 and 5");
                goto FirstLoop;
            }
            switch(secimNo)
            {
                case 1:
                    Saving.Save();
                    break;
                case 2:
                    Deleting.Delete();
                    break;
                case 3:
                    Updating.Update();
                    break;
                case 4:
                    Listing.List();
                    break;
                case 5:
                    Searching.Search();
                    break;
            }
        }
    }
}
