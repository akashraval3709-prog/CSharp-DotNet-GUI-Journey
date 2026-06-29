namespace Program_02
{

    internal class NumberIntoWord{
        public string First(int num )
        {
          
            string result = "";
            switch (num)
            {
                case 1:
                    result = "One";
                    break;
                case 2:
                    result = "Two";
                    break;
                case 3:
                    result = "Three";
                    break;
                case 4:
                    result = "Four";
                    break;
                case 5:
                    result = "Five";
                    break;
                case 6:
                    result = "Six";
                    break;
                case 7:
                    result = "Seven";
                    break;
                case 8:
                    result = "Eight";
                    break;
                case 9:
                    result = "Nine";
                    break;
                case 10:
                    result = "Ten";
                    break;



            }
            return result;
        }

        public string Second(int num)
        {

            string result = "";
            switch (num)
            {
                case 11:
                    result = "Eleven";
                    break;
                case 12:
                    result = "Twelve";
                    break;
                case 13:
                    result = "Thirteen";
                    break;
                case 14:
                    result = "Fourteen";
                    break;
                case 15:
                    result = "Fifteen";
                    break;
                case 16:
                    result = "Sixteen";
                    break;
                case 17:
                    result = "Seventeen";
                    break;
                case 18:
                    result = "Eighteen";
                    break;
                case 19:
                    result = "Nineteen";
                    break;
        
            }
            return result;
        }


        public string Therd(int num)
        {

            string result = "";
            switch (num)
            {
                case 2:
                    result = "Twenty";
                    break;
                case 3:
                    result = "Thirty";
                    break;
                case 4:
                    result = "Forty";
                    break;
                case 5:
                    result = "Fifty";
                    break;
                case 6:
                    result = "Sixty";
                    break;
                case 7:
                    result = "Seventy";
                    break;
                case 8:
                   result = "Eighty";
                    break;
                case 9:
                    result = "Ninety";
                    break;

            }
            return result;
        }

        public string Fourth(int num)
        {
            string result = "";
            switch (num)
            {
                case 1:
                    result = "One Hundred";
                    break;
                case 2:
                    result = "Two Hundred";
                    break;
                case 3:
                    result = "Three Hundred";
                    break;
                case 4:
                    result = "Four Hundred";
                    break;
                case 5:
                    result = "Five Hundred";
                    break;
                case 6:
                    result = "Six Hundred";
                    break;
                case 7:
                    result = "Seven Hundred";
                    break;
                case 8:
                    result = "Eight Hundred";
                    break;
                case 9:
                    result = "Nine Hundred";
                    break;
            }
            return result;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 999: ");
            int num = int.Parse(Console.ReadLine());
            int nums = num; 

            NumberIntoWord numberIntoWord = new NumberIntoWord();
            string finalResult = "";

            if (num < 1 || num > 999)
            {
                Console.WriteLine("Please enter a number between 1 and 999.");
                return;
            }


            if (num >= 100 && num <= 999)
            {
                int hundredDigit = num / 100;
                finalResult += numberIntoWord.Fourth(hundredDigit) + " ";
                num = num % 100;


                if (num >= 20 && num <= 99)
                {
                    int tensDigit = num / 10;
                    int onesDigit = num % 10;

                    finalResult += numberIntoWord.Therd(tensDigit);

                    if (onesDigit > 0)
                    {
                        finalResult += " " + numberIntoWord.First(onesDigit);
                    }
                }

                else if (num >= 11 && num <= 19)
                {
                    finalResult += numberIntoWord.Second(num);
                }

                else if (num >= 1 && num <= 10)
                {
                    finalResult += numberIntoWord.First(num);
                }

                Console.WriteLine($"The number {nums} in words is: {finalResult.Trim()}");
                Console.ReadLine();
            }
        }
    }
}

