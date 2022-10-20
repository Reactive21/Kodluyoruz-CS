public class Listing
{
    public static void List()
    {
        FirstLoop:
        Console.WriteLine("Phonebook listed is down below. Do you want to change its order? Y for yes, N for no.");
        string listing = Console.ReadLine();
        if (listing == "n")
        {
            for (int i = 0; i < Listers.names.Count; i++)
            {
                Console.WriteLine("Name {0}: ", Listers.names[i]);
                Console.WriteLine("Surname {0}: ", Listers.surnames[i]);
                Console.WriteLine("No {0}: ", Listers.no[i]);
            }
        }
        else if (listing == "y")
        {
            for(int i = Listers.names.Count; i> 0; i++)
            {
                Console.WriteLine("Name {0}: ", Listers.names[i]);
                Console.WriteLine("Surname {0}: ", Listers.surnames[i]);
                Console.WriteLine("No {0}: ", Listers.no[i]);
            }
        }
        else
            goto FirstLoop;
    }
}
