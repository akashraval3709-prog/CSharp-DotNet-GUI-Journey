using System;
using System.Collections;

namespace Hash__Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("Akash", 'A');
            ht.Add("Rohan", 'B');
            ht.Add("Meet", 'A');
            ht.Add("Vijay", 'C');

            Console.Write("Enter the name of the student to find their grade: ");
            string searchName = Console.ReadLine();

            if (ht.ContainsKey(searchName))
            {
                Console.WriteLine($"Grade: {ht[searchName]}");
            }
            else
            {
                Console.WriteLine($"Student '{searchName}' not found.");
            }

            Console.ReadKey();
        }
    }
}
