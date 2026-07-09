namespace program_04
{
    internal class Program
    {

       internal class Person
        {
            int age;
            string name;

            public int Age{ 
                get {
                    return age;
                }
                set
                {
                    if(value > 0 && value <= 100)
                    {
                        age = value;
                    }
                    else
                    {
                        Console.WriteLine("\nEnter a valid age (1 to 100)");
                    }
                }
            }


            public void ShowDetailes()
            {
                Console.WriteLine($"Name : {name}");
                Console.WriteLine($"Age : {age}");
            }


            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.Write("Enter your Name :");
            string name = Console.ReadLine();
            Console.Write("Enter your Age :");
            int age = int.Parse(Console.ReadLine());
            p.Age = age;
            p.Name = name;

            p.ShowDetailes();
                         
        }
    }
}
