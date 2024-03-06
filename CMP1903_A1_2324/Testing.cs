using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        public Testing()
        {
            //Creates 3 instances of dice
            Game game = new Game();
            while (true)
            {
                //Rolls 3 instances of dice
                int[] diceNumbers = game.RollDie();
                
                //Checks if values are valid.
                foreach (int i in diceNumbers)
                {
                    Debug.Assert(i > 0 && i <= 6, "Value not within correct range");
                }

                //Total sum of the 3 dice.
                int total = game.SumOfDice(diceNumbers);
                Console.WriteLine($"The total is sum is {total}");
                Debug.Assert(total >= 3 && total <= 18, "Sum of Dice is too large");

                
                //Allows user to stop rerolling.
                Console.WriteLine("Press enter to continue or write exit to stop");
                if (Console.ReadLine() == "exit")
                {
                    break;
                }
            }
        }
    }
}
