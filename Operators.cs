using System;

namespace Bot
{
    class program
    {
        static void Main(string[] args)
        {
            //Assigning
            int y = 4;
            y = y + 2;
            Console.WriteLine(y);
            y /= 2;
            Console.WriteLine(y);
            y *= 6;
            Console.WriteLine(y);

            //Logical Operators
            bool FirstCondition = true;
            bool SecondCondition = false;
            if(FirstCondition&&SecondCondition)
            {
                Console.WriteLine(true);
            }
            else if(FirstCondition||SecondCondition)
            {
                Console.WriteLine("maybe");
            }
            else
            {
                Console.WriteLine(false);
            }

            bool sonuc;
            int Fnum = 9;
            int Snum = 10;
            sonuc = Fnum < Snum;
            Console.WriteLine(sonuc);
            sonuc = Snum < Fnum;
            Console.WriteLine(sonuc);
            sonuc = Fnum >= Snum;
            Console.WriteLine(sonuc);
            sonuc = Fnum <= Snum;
            Console.WriteLine(sonuc);
            sonuc = Fnum != Snum;
            Console.WriteLine(sonuc);

            //Arithmetic Operators
            int result;
            int a = 1241;
            int b = 134;
            result = a + b;
            Console.WriteLine(result);
            result = a * b;
            Console.WriteLine(result);
            result = a - b;
            Console.WriteLine(result);
            result = a / b;
            Console.WriteLine(result);
            result = a % b;
            Console.WriteLine(result);
        }
    }
}
