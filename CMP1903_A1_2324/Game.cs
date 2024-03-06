using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
   public class Game
   {

       private Die[] dice;
       public int RollNumber = 1;

       //Creates 3 instance of die.
       public Game()
       {
           dice = new Die[3];
           for (int i = 0; i < 3; i++)
           {
               dice[i] = new Die();
           }
       }

       //Generates a random number for each instance of die.
       public int[] RollDie()
       {
           int[] rolls = new int[3];
           for (int i = 0; i < 3; i++)
           {
               Console.WriteLine("Rolling....");
               rolls[i] = dice[i].Roll();
               Console.WriteLine($"Die number {RollNumber} is {rolls[i]}");
               RollNumber++;
           }
           return rolls;
       }

       //Returns the sum of the 3 dice.
       public int SumOfDice(int[] diceNumbers)
       {
           int sum = 0;
           foreach (int i in diceNumbers)
           {
               sum += i;
           }
           return sum;
       }
   }

}
