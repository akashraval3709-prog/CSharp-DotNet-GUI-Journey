namespace Arrays.PasswordMasking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            char[] password = pass.ToCharArray();
            char[] maskedPassword = new char[password.Length];

            for (int i = 0; i < password.Length; i++)
            {
                maskedPassword[i] = '*';
            }

            string finalPassword = new string(maskedPassword);

            Console.WriteLine($"\nMasked Password: {finalPassword}");
            Console.ReadKey();
        }
    }
}
