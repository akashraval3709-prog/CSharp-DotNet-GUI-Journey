namespace Task02_SumAndAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,number ,sum=0,i=1;
           Console.Write("How many numbers you want to add : ");
            n = int.Parse( Console.ReadLine());
            while( i <= n)
            {
                Console.Write("Enter a Number "+ i +" : ");
                number =int.Parse(Console.ReadLine());
                sum += number;
                i++;

            }
            Console.WriteLine("Sum of the Number :" + sum);
            double avg =(double) sum / n;
            Console.WriteLine("Average of the Number :" + avg);

        }
    }
}
