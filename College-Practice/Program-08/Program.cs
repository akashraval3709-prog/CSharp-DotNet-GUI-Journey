using System;

namespace Program_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine($"\nDivision Result: {result}");

                int[] numbers = { 10, 20, 30, 40, 50 };

                Console.Write("\nEnter array index (0-4): ");
                int index = int.Parse(Console.ReadLine());

                Console.WriteLine($"Array Value: {numbers[index]}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nError: Cannot divide by zero.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nError: Invalid array index.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Please enter valid numeric values.");
            }
            finally
            {
                Console.WriteLine("\nProgram executed successfully.");
            }

            Console.ReadKey();
        }
    }
}
