using System.Diagnostics.CodeAnalysis;

namespace Indexers
{
    internal class Program
    {
        internal class Student
        {
            string size;
            int[] rollNo;
            String[] name;
            int i;

            public Student()
            {
            }

            public Student(int size)
            {
                rollNo = new int[size];
                name = new string[size];
            }

            public int this[int index]
            {
                get
                {
                    return rollNo[index];
                }
                set
                {
                    rollNo[index] = value;
                }
            }

            public string this[string index]
            {
                get
                {
                    i = int.Parse(index);
                    return name[i];
                }
                set
                {
                    i = int.Parse(index);
                    name[i] = value;
                }
            }

        }
       
        static void Main(string[] args)
        {
            Console.Write("How many do you want to enter Student roll_number and name :");
            int num = int.Parse(Console.ReadLine());

            Student stud  = new Student(num);

           

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter Rollnumber [{i + 1}] : ");
                stud[i] = int.Parse(Console.ReadLine());
                Console.Write($"Enter Name [{i + 1}] : ");
                string j = Convert.ToString(i);
                stud[j] = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("\n----Student---");
            for (int i = 0; i < num; i++)
            {
                string j = Convert.ToString(i);
                Console.WriteLine($"Rollno : {stud[i]}\nName : {stud[j]}");

            }

        }
    }
}
