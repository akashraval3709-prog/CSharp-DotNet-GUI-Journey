namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correntPassword = "Akash09";
            string userInput = "";
            int attempts = 1;

            Console.WriteLine("You have 3 attempts to enter the correct password.");
            while (true)
            {
                if (attempts > 3)
                {
                    Console.WriteLine("\nACCOUNT LOCKED!");
                    break;
                }
                Console.Write("\nEnter your password : ");
                userInput = Console.ReadLine();

                if(userInput == correntPassword)
                {
                  Console.WriteLine("\nAccess granted. Welcome!");
                    break;
                }

                else
                {
                     Console.WriteLine("\nIncorrect password. Please try again.");
                }

                attempts++;
                
            }
           
        }
    }
}

