using System.Net.NetworkInformation;

namespace DigitalWallet
{
    class DigitalWallet
    {
        private readonly int _walletID;
        private string _name;
        private int _secretPIN, _balance;

        public DigitalWallet(int WalletID, string name)
        {
            _walletID = WalletID;
            _name = name;

        }


        public int WalletID
        {
            get { return _walletID; }
        }
        public string Name
        {
            get { return _name; }
            set
            { if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be null or empty.");
                }
                else
                {
                    _name = value;
                }

            }


        }


        public int secretPIN
        {

            set
            {
                if (value < 1000 || value > 9999)
                {
                    Console.WriteLine("\nPIN must be a 4-digit number.");
                    
                }
                else
                {
                    _secretPIN = value;
                }
            }
        }
        public int Balance
        {
            get { return _balance; }
        }
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                _balance += amount;
            }

        }

        public bool varifyPIN(int pin)
        {
            return _secretPIN == pin;
        }


       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your wallet ID:");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter your name:");
            string name = Console.ReadLine();

           

            DigitalWallet wallet = new DigitalWallet(id, name);


            int pin;
            while (true)
            {
                Console.Write("Enter your 4 Digit secret PIN:");
                pin = int.Parse(Console.ReadLine());

                wallet.secretPIN = pin; 

                if (wallet.varifyPIN(pin))
                {
                    break; 
                }

                Console.WriteLine("Please try again with a valid PIN.\n");
            }


            Console.Write("Enter the amount to deposit:");
            int amount = int.Parse(Console.ReadLine());

            wallet.Deposit(amount);

           
           

            while (true)
            {
                Console.Write("Enter your 4 Digit secret PIN to view your wallet details:");
                int secretPin = int.Parse(Console.ReadLine());
                if (wallet.varifyPIN(secretPin))
                {
                    Console.WriteLine("-- Your Wallet Details --");
                    Console.WriteLine($"Wallet Id : {wallet.WalletID}");
                    Console.WriteLine($"User Name : {wallet.Name}");
                    Console.WriteLine($"Balance : {wallet.Balance}");
                    break;

                }
                else
                {
                    Console.WriteLine("Incorrect PIN. Access denied.");
                }


            }


        }
    }

}
