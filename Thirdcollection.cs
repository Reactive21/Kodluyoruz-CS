using System;
using System.Collections.Generic;
using System.Collections;

namespace Collections_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");

            string sentence = Console.ReadLine();
            string vowels = "aeiou";
            var arlist = new ArrayList();
            if(!string.IsNullOrEmpty(sentence))
            {
                string sentence2 = sentence.ToLower();
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (vowels.Contains(sentence[i]))
                    {
                        arlist.Add(sentence[i]);
                    }
                }
            }
            foreach(var item in arlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
