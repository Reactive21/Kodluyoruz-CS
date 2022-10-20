using System;
public class Saving
{
    public static void Save()
    {
        FirstLoop:
        Console.WriteLine("This screen lets you add numbers to system.");
        Console.Write("Enter name please:");
        Listers.names.Add(Console.ReadLine());
        Console.Write("Enter surname please:");
        Listers.surnames.Add(Console.ReadLine());
        Console.Write("Enter phone number please:");
        Listers.no.Add(Console.ReadLine());

        Console.WriteLine("Do you wish to add any other info? 1 for Yes, 2 for No.");
        string num = Console.ReadLine();
        if (num == "1")
        {
            goto FirstLoop;
        }
    }

}
