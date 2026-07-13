namespace Arrays.InventorySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] inventory = new string[3, 2];

            inventory[0, 0] = "Laptop";
            inventory[0, 1] = "Ahmedabad";

            inventory[1, 0] = "Mobile";
            inventory[1, 1] = "Palanpur";

            inventory[2, 0] = "Tablet";
            inventory[2, 1] = "Surat";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (inventory[i, j] == "Palanpur")
                    {
                        Console.WriteLine($"Product found in {inventory[i, j]} : {inventory[i, j - 1]}");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
