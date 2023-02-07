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
        //Created method to check position
        public static void CheckForPosition()
        {
            int position = 0;
            Console.WriteLine("The position of player start with {0}", position);
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine("The random number of dice: " + diceRoll);
            Random random1 = new Random();
            int option = random1.Next(1, 4);
            switch (option)
            {
                case 1:
                    Console.WriteLine("Player remain at same position " + position);
                    break;
                case 2:
                    position = position + diceRoll;
                    Console.WriteLine("Player move ahead by number of Dice rolled " + position);
                    break;
                case 3:
                    position = position - diceRoll;
                    Console.WriteLine("Player move behind by number of dice rolled " + position);
                    break;
            }
        }
        //Created method for exact win condition of player
        public static void PlayerWinCondition()
        {
            int position = 0;
            int count = 0;
            Random random = new Random();
            Random random1 = new Random();
            while (position < 100)
            {
                int diceRoll = random.Next(1, 7);
                int option = random1.Next(1, 4);
                count = count + 1;
                switch (option)
                {
                    case 1:
                        position = position + diceRoll;
                        if (position > 100)
                            position = 100;
                        Console.WriteLine("Player move ahead by number of Dice rolled " + position);
                        break;
                    case 2:
                        position = position - diceRoll;
                        if (position < 0)
                            position = 0;
                        Console.WriteLine("Player move behind by number of Dice rolled " + position);
                        break;
                    case 3:
                        Console.WriteLine("Player remain at same position " + position);
                        break;
                }
            }
            Console.WriteLine("The number of time dice rolled to get winning position " + count);
        }
    }
}
