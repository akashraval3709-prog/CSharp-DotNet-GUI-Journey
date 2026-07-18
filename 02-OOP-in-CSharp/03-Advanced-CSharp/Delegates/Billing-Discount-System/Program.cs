namespace delegateProgram
{
    internal class Program
    {
        public delegate double DiscountDelegate(double amount);

        public static double NoDiscount(double amount)
        {
            return amount;
        }

        public static double FestivalDiscount(double amount)
        {
            return amount - (amount * 0.10);
        }

        public static double VIPDiscount(double amount)
        {
            return amount - (amount * 0.20);
        }

        public static void ProcessBill(double totalAmount, DiscountDelegate discountScheme)
        {
            double finalAmount = discountScheme(totalAmount);
            Console.WriteLine($"Original Amount: {totalAmount}");
            Console.WriteLine($"Final Payable Amount: {finalAmount}\n");
        }
        static void Main(string[] args)
        {

            DiscountDelegate del = null;
            Console.Write("Emter your amount  : ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("1 Regular Customer (No Discount)\n2 Festival Offer (10% Off)\n3 VIP Member (20% Off)\nEnter your choice : ");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    del = NoDiscount;
                    break;
                case "2":
                    del = FestivalDiscount;
                    break;
                case "3":
                    del = VIPDiscount;
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
            if (del != null)
            {
                ProcessBill(amount, del);
            }

        }
    }
}
