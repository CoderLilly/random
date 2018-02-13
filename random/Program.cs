using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random
{
    class Program
    {
        private static Random rnd = new Random();
        static void Main(string[] args)
        {
            int die1 = dieRoll();
            int die2 = dieRoll();
            int die3 = dieRoll();
            int die4 = dieRoll();

            Console.WriteLine(die1);
            Console.WriteLine(die2);
            Console.WriteLine(die3);
            Console.WriteLine(die4);

            Console.ReadLine();
        }

        public static int dieRoll()
        {           
            int die = rnd.Next(1, 7);
            return die;
        }      
    }
}
