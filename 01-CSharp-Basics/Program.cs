using System;

namespace CSharp_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Akash";
            bool isStudent = true;
            double piValue = 3.14;
            string priceText;
            int finalPrice,a = 10,b = 3,num;

            int age = 20;
            bool hasLicense = true,canDrive;

            int newPi = (int)piValue;
            Console.WriteLine(newPi);
            Console.WriteLine(name);
            Console.WriteLine(isStudent);

            priceText = "499";
            finalPrice=int.Parse(priceText);

            Console.WriteLine(finalPrice+1);

            Console.WriteLine(a % b);
            Console.WriteLine(a > b);


            canDrive= age >= 18 && hasLicense == true;

            Console.WriteLine(canDrive);


            Console.WriteLine();
            Console.WriteLine("Enter a number to check if it's even or odd:");
             num= int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("This is an Even Number");
            }
            else
            {
                Console.WriteLine("This is an Odd Number");
            }

            int n;
            Console.WriteLine("Enter a number to print its multiplication table:");
            n=Convert.ToInt32(  Console.ReadLine());
            for (int i =1; i <=n; i++)
            {
                Console.WriteLine("\n Table :" + i);
                for (int j =1; j<= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }



    }
    
    
}
