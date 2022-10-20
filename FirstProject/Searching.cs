public class Searching
{
    public static void Search()
    {
    FirstLoop:
        Console.WriteLine("Enter the name or surname that you want to find his/her info:");
        string finding = Console.ReadLine();
        for(int i = 0; i< Listers.names.Count;i++)
        {
            if (Listers.names[i] == finding || Listers.surnames[i] == finding)
            {
                Console.WriteLine("Name of her/his: ", Listers.names[i]);
                Console.WriteLine("Surname of her/his: ", Listers.surnames[i]);
                Console.WriteLine("No of her/his: ", Listers.no[i]);
            }
        }
        Console.WriteLine("Do you want to check again? Y for yes, N for no.");
        string checking = Console.ReadLine();
        if (checking == "y")
            goto FirstLoop;
    }
}
