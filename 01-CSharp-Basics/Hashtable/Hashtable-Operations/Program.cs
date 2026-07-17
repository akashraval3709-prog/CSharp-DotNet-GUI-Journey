using System;
using System.Collections;

namespace HashTableOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable st = new Hashtable();

            while (true)
            {
                Console.WriteLine("\n===== HASHTABLE OPERATIONS MENU =====");
                Console.WriteLine("1. Add Student Name");
                Console.WriteLine("2. Add Roll Number / Age");
                Console.WriteLine("3. Remove Detail");
                Console.WriteLine("4. Display Details");
                Console.WriteLine("5. Clear All Details");
                Console.WriteLine("6. Get Total Count");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Key: ");
                        string keyStr = Console.ReadLine();

                        Console.Write("Enter Student Name: ");
                        string valueStr = Console.ReadLine();

                        if (!st.ContainsKey(keyStr))
                        {
                            st.Add(keyStr, valueStr);
                            Console.WriteLine("Student added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Key already exists.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter Key: ");
                        string keyInt = Console.ReadLine();

                        Console.Write("Enter Number Value: ");
                        int valueInt = int.Parse(Console.ReadLine());

                        if (!st.ContainsKey(keyInt))
                        {
                            st.Add(keyInt, valueInt);
                            Console.WriteLine("Value added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Key already exists.");
                        }
                        break;

                    case "3":
                        Console.Write("Enter Key to Remove: ");
                        string removeKey = Console.ReadLine();

                        if (st.ContainsKey(removeKey))
                        {
                            st.Remove(removeKey);
                            Console.WriteLine("Detail removed successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Key not found.");
                        }
                        break;

                    case "4":
                        Console.WriteLine("\n----- Student Details -----");

                        if (st.Count == 0)
                        {
                            Console.WriteLine("Hashtable is empty.");
                        }
                        else
                        {
                            foreach (DictionaryEntry item in st)
                            {
                                Console.WriteLine($"{item.Key} : {item.Value}");
                            }
                        }

                        break;

                    case "5":
                        st.Clear();
                        Console.WriteLine("Hashtable cleared successfully.");
                        break;

                    case "6":
                        Console.WriteLine($"Total Items : {st.Count}");
                        break;

                    case "7":
                        Console.WriteLine("Thank you!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
