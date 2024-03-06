using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
         private int currentValue;
         //Static means this isntance of random belongs to the whole class and not each instance, this way it isnt seeded in quick succession.
         private static Random random = new Random();
        
         //Generates a random integer between 1 and 6.
         public int Roll()
         {          
             CurrentValue = random.Next(1, 7);
             return currentValue;
         }
    }
}
