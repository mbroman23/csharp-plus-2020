using System;

namespace Session02Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want icecream?");

            var key = Console.ReadKey();
            if (key.KeyChar == 'n')
            {
                return;
            }

            else
            {
                Console.WriteLine("Enter your flavour: ");
                var flavour = Console.ReadLine();
                Console.WriteLine("Here is your " + flavour + "-icecream!");
            }

            Console.ReadKey();
        }
    }
}
