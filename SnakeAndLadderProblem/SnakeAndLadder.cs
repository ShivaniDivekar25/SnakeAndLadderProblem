using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    //Created class Snake And Ladder
    public class SnakeAndLadder
    {
        //Created method position
        public static void Position()
        {
            int position = 0;
            Console.WriteLine("The position of player start with {0}", position);
        } 
        //Created method Die rolled
        public static void DieRolled()
        {
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("The random number of dice: " + diceRoll);
        }

    }
}
