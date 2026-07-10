using System;

namespace Program_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Upper Lower
            Console.Write("Enter any String convert (Upper / Lower ) case : ");
            string s = Console.ReadLine();

            string toUpper = s.ToUpper();
            Console.WriteLine($"Upper case string : {toUpper}");

            string toLower = s.ToLower();
            Console.WriteLine($"Lower case string : {toLower}");

            // concatenation
            Console.WriteLine("\nEnter any String for concatenation : ");
            Console.Write("Enter any String One : ");
            string str1 = Console.ReadLine();

            Console.Write("Enter any String Two : ");
            string str2 = Console.ReadLine();

            string concat = String.Concat(str1, str2);

            Console.WriteLine($"\nConcatenated String : {concat}");

            //SubString
            Console.Write("\nEnter any String for find substring : ");
            string str = Console.ReadLine();

            Console.Write("Enter start position : ");
            int subStrOp = int.Parse(Console.ReadLine());

            Console.Write("Enter length : ");
            int subStrEd = int.Parse(Console.ReadLine());

            string findSubStr = str.Substring(subStrOp, subStrEd);

            Console.WriteLine($"\nYour substring is : {findSubStr}");


            // Insert
            Console.Write("\nEnter any String for Insert : ");
            string insertStr = Console.ReadLine();

            Console.Write("Enter position to insert : ");
            int insertPos = int.Parse(Console.ReadLine());

            Console.Write("Enter text to insert : ");
            string insertText = Console.ReadLine();

            string insertResult = insertStr.Insert(insertPos, insertText);

            Console.WriteLine($"After Insert : {insertResult}");


            // Remove
            Console.Write("\nEnter any String for Remove : ");
            string removeStr = Console.ReadLine();

            Console.Write("Enter start position : ");
            int removePos = int.Parse(Console.ReadLine());

            Console.Write("Enter number of characters to remove : ");
            int removeLen = int.Parse(Console.ReadLine());

            string removeResult = removeStr.Remove(removePos, removeLen);

            Console.WriteLine($"After Remove : {removeResult}");


            // IndexOf
            Console.Write("\nEnter any String for IndexOf : ");
            string indexStr = Console.ReadLine();

            Console.Write("Enter text to search : ");
            string searchText = Console.ReadLine();

            int index = indexStr.IndexOf(searchText);

            Console.WriteLine($"Index Position : {index}");

            Console.ReadKey();
        }
    }
}
