namespace Encapsulation.BankAccount
{


    internal class BankAccount
    {
        private int _age, _balance;

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("\nAge must be 18 or above to open an account!");
                    
                }
                else if(value > 100)
                {
                    Console.WriteLine("\nAge cannot be greater than 100!");

                }
            
                else
                {
                    _age = value;
                }
            }
        }

        public int Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance cannot be negative!");
                    
                }
                else
                {
                    _balance = value;
                }
            }
        }
    }
    internal class Program
    {



        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your initial balance: ");
            int balance = int.Parse(Console.ReadLine());

            account.Name = name;

            account.Age = age;

            account.Balance = balance;
            if (account.Age < 18 || account.Balance < 0)
            {
                Console.WriteLine("\nAccount creation failed due to invalid age or balance.");
                return;
            }
            else
            {

                Console.WriteLine("\n--- Displaying Account Details ---\n");
                Console.WriteLine("  Account Holder: " + account.Name);
                Console.WriteLine("  Account Holder Age: " + account.Age);
                Console.WriteLine("  Account Balance: " + account.Balance);
                Console.ReadLine();
            }
        }
    }
    
}  
