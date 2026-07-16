using System;

namespace staticVar
{
    internal class Program
    {
        internal class Customer
        {
            
            private string name;
            private int age;
            private int customerId; 

           
            private static int idCounter = 1000;
            private static int totalCustomers = 0;

            public Customer(string name, int age)
            {
                totalCustomers++; 
                idCounter++;      

                this.customerId = idCounter; 
                this.Name = name;            
                this.Age = age;              
            }


            
            string Name
            {
                get { return name; }
                set { name = value; }
            }

             int Age
            {
                get { return age; }
                set
                {
                    if (value > 0) { age = value; }
                    else { age = 18; } 
                }
            }

            
           
            public static int TotalCustomers
            {
                get { return totalCustomers; }
            }

            public void ShowDetails()
            {
                Console.WriteLine("\n------------------------");
                Console.WriteLine($"ID   : {customerId}"); 
                Console.WriteLine($"Name : {Name}");       
                Console.WriteLine($"Age  : {Age}");        
                Console.WriteLine("------------------------");
            }
        }

        static void Main(string[] args)
        {
            
            Console.Write("How many customers do you want to enter?: ");
            int count = int.Parse(Console.ReadLine());

           
            Customer[] custArray = new Customer[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\n--- Enter Details for Customer [{i + 1}] ---");

                Console.Write("Enter Name: ");
                string inputName = Console.ReadLine();

                Console.Write("Enter Age: ");
                int inputAge = int.Parse(Console.ReadLine());

                
                custArray[i] = new Customer(inputName, inputAge);
            }

           
            Console.WriteLine("\n======= ALL CUSTOMER DETAILS =======");
            for (int i = 0; i < count; i++)
            {
                custArray[i].ShowDetails();
            }

            
            Console.WriteLine($"\nTotal Registered Customers in Bank: {Customer.TotalCustomers}");
        }
    }
}
