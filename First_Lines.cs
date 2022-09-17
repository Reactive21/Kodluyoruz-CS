using System;

namespace Bot
{
    class program
    {
        static void Main(string[] args)
        {
            //String Example
            string str1 = "Eren";
            string str2 = "Topaçoğlu";
            string str3 = str1 + " " + str2;
            Console.WriteLine(str3);
            //Integer Example
            int int1 = 3;
            int int2 = 5;
            int int3 = int1 + int2;
            Console.WriteLine(int3);
            //Boolean Example
            bool k = 5 < 4;
            Console.WriteLine(k);
            //DateTime example
            string h_m = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(h_m);

        }
    }
}
