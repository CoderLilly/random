using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        //private static Random rnd = new Random();
        //static void Main(string[] args)
        //{
        //    int die1 = dieRoll();
        //    int die2 = dieRoll();
        //    int die3 = dieRoll();
        //    int die4 = dieRoll();

        //    Console.WriteLine(die1);
        //    Console.WriteLine(die2);
        //    Console.WriteLine(die3);
        //    Console.WriteLine(die4);

        //    Console.ReadLine();
        //}

        //public static int dieRoll()
        //{           
        //    int die = rnd.Next(1, 7);
        //    return die;
        //}      

        //Genius.  I had wondered but didn't know that I 
        //could even put things here to be used by all methods
        public static Random number = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("\t\tDice Game\r\n");

            Console.Write("Hello!  What is your name?  ");
            string playerName = Console.ReadLine();

            Console.WriteLine($"\r\nWelcome {playerName}!  Press enter to roll the dice. Be the first to reach 20 to win!\r\n");
            Console.ReadLine();
            Console.Clear();


            int playerScore = 0;
            int computerScore = 0;

            while (playerScore < 21 && computerScore < 21)
            {
                int diceA = Roll();//before Lilly posted her snippet, I had
                int diceB = Roll();//made 'timers' and put them between the 
                int diceC = Roll();//dice rolls to avoid getting the same
                int diceD = Roll();//random number repeatedly :/


                playerScore = playerScore + diceA + diceB;
                Console.Write($"{playerName}'s roll: {diceA}, {diceB}");
                Console.WriteLine($"\tTotal Score: {playerScore}\r\n");

                //I really like using the \t and \r\n to 'format' the text in the
                //console, but I'm sure there's a better way to go about it

                computerScore = computerScore + diceC + diceD;
                Console.Write($"Computer's roll: {diceC}, {diceD}");
                Console.WriteLine($"\tTotal Score: {computerScore}\r\n");


                Console.ReadLine();
                Console.Clear();
            }


            Console.WriteLine(WinLoseTie(playerScore, computerScore));


            Console.ReadLine();
        }


        private static int Roll()
        {
            return number.Next(1, 7);
        }

        //probably didn't NEED this method, but the main looks much
        //prettier without it :)
        public static string WinLoseTie(int playerScore, int computerScore)
        {
            if (playerScore > computerScore)
            {
                return "\r\nYou Won!";
            }
            else if (playerScore < computerScore)
            {
                return "\r\nYou Lost";
            }
            else if (playerScore == computerScore)
            {
                return "\r\nIt's a tie!";
            }
            else
                return "\r\nI don't know...";
        }
    }
}
