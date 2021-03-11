using System;

namespace PetProjects
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string name = "no Name";
            int favNum = 0;

            Console.WriteLine("Hello World!");

            Console.WriteLine("Lets get a string, type your name : ");
            name = Console.ReadLine(); // get input string

            Console.WriteLine("Hi " + name);

            Console.WriteLine("Whats your favorite integer? : ");
            favNum = int.Parse(Console.ReadLine());

            Console.WriteLine(favNum + " is a pretty cool number after all, not surprised.");

            Console.WriteLine("Bye!");

        }
    }
}
