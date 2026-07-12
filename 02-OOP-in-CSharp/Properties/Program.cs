namespace propertise
{
    internal class Program
    {
       internal class Employee
        {
            
            string name;
            float salary;

            public int ID { get; set; }

            public string Ename{
                get
                {
                    return name;
                }
                set
                {
                    if(value == "")
                    {
                        Console.WriteLine("Name can't be empty");
                        return;
                    }

                    name = value;

                }
            }

            public float Salary
            {
                get
                {
                    return salary;
                }

                set
                {
                    if(value < 0)
                    {
                        Console.WriteLine("Salary can't be negative");
                        return;
                    }

                    salary = value;
                }
            }


        }
        static void Main(string[] args)
        {

            Employee e1 = new Employee();
            Console.Write("Enter Employee number : ");
            int eno = int.Parse(Console.ReadLine());

            e1.ID = eno;

            Console.Write("Enter Employee name : ");
            string name = Console.ReadLine();

            e1.Ename = name;

            Console.Write("Enter Employee salary : ");
            float salary = float.Parse(Console.ReadLine());

            e1.Salary = salary;

            Console.WriteLine("\n\t---Employee Details---");


            Console.WriteLine($"ID : {e1.ID}\nName : {e1.Ename}\nSalary : {e1.Salary} ");



        }
    }
}
