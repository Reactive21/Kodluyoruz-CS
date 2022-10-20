public class Updating
{
    public static void Update()
    {
    FirstLoop:
        bool result = false;
        Console.WriteLine("Enter the name that you want to update his/her info:");
        string updateName = Console.ReadLine();
        for(int i = 0; i < Listers.names.Count; i++)
        {
            if(Listers.names[i] == updateName || Listers.surnames[i] == updateName)
            {
                result = true;
                Console.WriteLine("Enter the new name of her/his:");
                Listers.names[i] = Console.ReadLine();
                Console.WriteLine("Enter the new name of her/his:");
                Listers.surnames[i] = Console.ReadLine();
                Console.WriteLine("Enter the new name of her/his:");
                Listers.no[i]= Console.ReadLine();
            }
            break;
        }
        if (result==false)
        {
            Console.WriteLine("The data you entered can not be found. Do you wish to try again? Y for yes, N for no.");
            string thing1 = Console.ReadLine();
            if (thing1 == "y")
            {
                goto FirstLoop;
            }
        }
    }
}
