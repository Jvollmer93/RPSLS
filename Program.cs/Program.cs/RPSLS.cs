using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class RPSLS
    {
        public void DetermineWinner(int assignedValuePlayerOne, int assignedValuePlayerTwo)
        {
            int someNumber = (5 + assignedValuePlayerOne - assignedValuePlayerTwo) % 5;
            if ((someNumber == 1)||(someNumber == 3))
            {
                Console.WriteLine("Player 1 wins this round!");
                Console.ReadLine();
                //playerOne.wins++;
            }
            else if ((someNumber == 2)||(someNumber == 4))
            {
                Console.WriteLine("Player 2 wins this round!");
                Console.ReadLine();
                //playerTwo.wins++;
            }
        }
    }
}
