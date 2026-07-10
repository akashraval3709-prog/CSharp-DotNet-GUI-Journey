namespace program_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Impelment of jagged array  for store different student grades \n ");

            Console.Write("How many do you wnat to enter grades row : ");
            int rows = int.Parse(Console.ReadLine());
            char[][] grades = new char[rows][];

            for(int i=0; i<rows; i++)
            {
                Console.Write("How many do you wnat to enter grades column :");
                int columns = int.Parse(Console.ReadLine());

                grades[i] = new char[columns];

                for (int j=0;j<columns;j++ )
                {
                    Console.Write($"Enter grades [{j+1}] :");
                    char gr = Convert.ToChar(Console.ReadLine());
                    grades[i][j] = gr;
                }
            }

            Console.WriteLine("\nStudent Grades");
            foreach(char[] items in grades)
            {
                foreach(char g in items)
                {
                    Console.Write($" {g}");
                }
                Console.WriteLine();
            } 

        }
    }
}
