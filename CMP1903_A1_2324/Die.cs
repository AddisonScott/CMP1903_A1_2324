using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        //Current Value Property
        private int CurrentValue;

        
        //Method to roll dice and return integer
        public int Roll()
        {
            Random random = new Random();
            CurrentValue = random.Next(1,7);
            return CurrentValue;

        }
    }
}
