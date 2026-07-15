using System;
using System.Collections;

namespace Collections.ArrayList.StudentFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList students = new ArrayList()
            {
                "Akash",
                "Rohan",
                "Amit",
                "Pooja",
                "Anil",
                "Karan",
                "Aarya"
            };

            ArrayList filteredStudents = new ArrayList();

            Console.WriteLine("Students whose names start with 'A':\n");

            foreach (string name in students)
            {
                if (name.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                {
                    filteredStudents.Add(name);
                }
            }

            foreach (string student in filteredStudents)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey();
        }
    }
}
