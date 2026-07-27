using System.ComponentModel;

namespace CopyConstructor
{
    public class Product
     {
        string ProductName;
        double price;

       public Product(string name , double price)
        {
            this.ProductName = name;
            this.price = price;
        }

      public  Product (Product existObj)
        {
            this.ProductName = existObj.ProductName;
            this.price = existObj.price;
            
        }
      
          public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
        public void Display()
        {

           
            
            Console.WriteLine($"Product Name : {ProductName}\nPrice : {price}");
           
            

        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {

             Console.WriteLine("---Copy Construcotr---");

            Console.WriteLine("\n--Product Object 1-- ");

            Console.Write("Enter Product Name :");
            string name1 = Console.ReadLine();
            Console.Write("Enter Product Price : ");
            double price1 = double.Parse(Console.ReadLine());


            Product p1 = new Product(name1, price1);

           

            


            Product p2 = new Product(p1);
           
            Console.WriteLine("\n--P1 Object Dataile-- ");
            p1.Display();

            Console.WriteLine("\n-- P2 Details (Copied from P1) --");
            p2.Display();

            Console.Write("\nEnter new discounted price for P2: ");
            p2.Price = double.Parse(Console.ReadLine());

            Console.WriteLine("\n-- P2 Details (Copied from P1) --");
            p2.Display();


            Console.WriteLine("\n---------------------------------------------------");
            Console.WriteLine("After modifying P2 Price (Proving State Isolation):");
            Console.WriteLine("\n-- P1 Details (Should remain unchanged) --");
            p1.Display();


            Console.WriteLine("\n-- P2 Details (Should show updated price) --");
            p2.Display();
        }
    }
}
