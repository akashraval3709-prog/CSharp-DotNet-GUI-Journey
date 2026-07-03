using System;

namespace Program_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the main string: ");
            string mainString = Console.ReadLine();

            Console.Write("Enter the substring to search: ");
            string subString = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(mainString) || string.IsNullOrWhiteSpace(subString))
            {
                Console.WriteLine("\nMain string and substring cannot be empty.");
                return;
            }

            int index = -1;
            int count = 0;

            while ((index = mainString.IndexOf(subString, index + 1, StringComparison.OrdinalIgnoreCase)) != -1)
            {
                count++;
            }

           
            if (count > 0)
            {
                Console.WriteLine($"\nThe substring \'{subString}\' was found \'{count}\' time(s).");
            }
            else
            {
                Console.WriteLine($"\nThe substring \'{subString}\' was not found.");
            }

            

            Console.ReadKey();
        }
    }
}
