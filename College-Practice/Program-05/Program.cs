namespace program_05
{
    internal class Program
    {
        internal class Area
        {
            int width, hight;
            float PI;
           public Area()
            {

            }
       public  Area(int width ,int hight,float pi=3.14F )
            {
                this.width = width;
                this.hight = hight;
                this.PI = pi;
            }

           public int CalculateArea()
            {
                return this.width * this.hight;
            }

            public float CalculateArea(int r)
            {
                return PI * (float)r * r;
            }
        }
        static void Main(string[] args)
        {

            Area area1 = new Area();

            Console.Write("Enter Width for ractangle : ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter Hight for ractangle : ");
            int higth = int.Parse(Console.ReadLine());


            Area area2 = new Area(width,higth);
            int rectAns=area2.CalculateArea();


            Console.Write("\nEnter Readius of circle: ");
            int readius = int.Parse(Console.ReadLine());

            float circleAns=area2.CalculateArea(readius);


            Console.WriteLine($"Area of rectangle : {rectAns}");
            Console.WriteLine($"Area of circle : {circleAns:f2}");


        }
    }
}
