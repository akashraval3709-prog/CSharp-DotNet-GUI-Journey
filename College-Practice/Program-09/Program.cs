namespace program_09
{
    internal class Program
    {
         public  delegate int operation(int num1,int num2 );
        public class ArithmetiOperations
        {
            public   int Addition(int a , int b)
            {            
                return a + b;
            }            
                         
            public   int Multiplication(int num1 ,int num2)
            {
                return num1 * num2;
            }

            public  void Display(int a, int b ,operation op)
            {
               int result = op(a, b);
                Console.WriteLine($"Result : {result}");
            }
        }
        static void Main(string[] args)
        {
            operation op = null;
            Console.Write("1 Addition\n2 Multiplication\nEnter your choice : ");

            string choice = Console.ReadLine();
            ArithmetiOperations ar = new ArithmetiOperations();
            int num1=0,num2=0;

            switch (choice)
            {
                case "1":

                    Console.Write("Enter a number1 : ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter a number2 : ");
                    num2 = int.Parse(Console.ReadLine());
                     op = ar.Addition;
                    break;
                case "2":
                    Console.Write("Enter a number1 : ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter a number2 : ");
                    num2 = int.Parse(Console.ReadLine());
                    op = ar.Multiplication;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;

            }
                    if (op != null)
                    {
                        ar.Display(num1 ,num2 ,op);
                   }

        }
    }
}
