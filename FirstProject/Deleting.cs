public class Deleting
{
    public static void Delete()
    {
    FirstLoop:
        bool result = false;
        Console.WriteLine("Enter the name or surname that you want to delete from system:");
        string deleteName = Console.ReadLine();
        for(int i = 0; i < Listers.names.Count; i++)
        {
            if (Listers.names[i] == (deleteName) || Listers.surnames[i] == (deleteName))
                {
                    result = true;
                Console.WriteLine("The person you chose is numbered with {0}, about to get deleted. Are you sure? Y for yes, N for no.");
                string thing = Console.ReadLine();
                if (thing == "y")
                {
                    Listers.names.RemoveAt(i);
                    Listers.surnames.RemoveAt(i);
                    Listers.no.RemoveAt(i);
                    Console.WriteLine("Person that you chose successfully deleted.");
                }
                break;
            }
        }
        if (result == false)
        {
            Console.WriteLine("The data you entered can not be found. Do you wish to try again? Y for yes, N for no.");
            string thing1 = Console.ReadLine();
            if(thing1 == "y")
            {
                goto FirstLoop;
            }
        }

    }
}
