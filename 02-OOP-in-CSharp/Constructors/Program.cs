namespace Constructors
{



    internal class Program
    {


        internal class Area
        {
            int length;

            static Area()
            {
                Console.WriteLine("Static constructor is called");
            }
            public Area()
            {
                Console.WriteLine("Object is created");
            }

            public Area(int l)
            {
                this.length = l;

            }

            public void Display()
            {
                Console.WriteLine("Length: " + length * length);
            }

            ~Area()
            {

            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the square:");
            int l = int.Parse(Console.ReadLine());
            Area area1 = new Area();
            Area area2 = new Area(l);
            area2.Display();


        }
    }

}

