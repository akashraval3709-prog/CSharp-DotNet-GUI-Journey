namespace Program_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age :");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your city: ");
            string city = Console.ReadLine();

            Console.WriteLine("\n--- User Information ---");
            Console.WriteLine($" Name: {name}");
            Console.WriteLine($" Age: {age}");
            Console.WriteLine($" City: {city}");

        }
    }
}
