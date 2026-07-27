namespace CopyConstructorPlayer
{
    internal class Player
    {
        string PlayerName;
        int[] Scores;

       public Player(string pName , int[] pSocres)
        {
            PlayerName = pName;
            this.Scores = pSocres;
        }
        public int this[int index]
        {
            get
            {
                return Scores[index];
            }

            set
            {
                Scores[index] = value;
            }
        }

        public Player(Player existObj )
        {
            this.PlayerName = existObj.PlayerName;
            this.Scores = (int[])existObj.Scores.Clone();
        }

        public void DisplayScores()
        {
            Console.WriteLine($"Player Name: {PlayerName}");
            Console.Write("Scores: ");
            foreach (int score in Scores)
            {
                Console.Write($"{score} ");
            }
            Console.WriteLine("\n-----------------------");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Player Array Deep Copy Demo ---");

            int[] initialScores = { 50, 80, 100 };

           
            Player player1 = new Player("Akash", initialScores);

          
            Player player2 = new Player(player1);

            Console.WriteLine("\n[ Before Modifying Player 2 Scores ]");
            player1.DisplayScores();
            player2.DisplayScores();

            
            player2[0] = 99;

            Console.WriteLine("\n[ After Setting player2[0] = 99 ]");
            Console.WriteLine("Player 1 (Unchanged original array):");
            player1.DisplayScores(); 

            Console.WriteLine("Player 2 (Copied independent array):");
            player2.DisplayScores(); 
        }
    }
}
