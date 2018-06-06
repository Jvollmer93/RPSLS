using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Player
    {
        public int wins;
        public string playerChoice;
        public string playerName;

        public Player()
        {
            wins = 0;
            playerChoice = "";
            playerName = Console.ReadLine();
        }

        public bool DetermineNumberOfPlayers()
        {
            Console.WriteLine("Will there be 2 players, or 1 player against the Computer? Enter 1 or 2:");
            string userInput = Console.ReadLine();
            while ((userInput != "1") && (userInput != "2"))
            {
                Console.WriteLine("Incorrect input, please enter '1' to play against the Computer, or '2' for two players:");
                userInput = Console.ReadLine();
            }
            if (userInput == "1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int MakeChoice()
        {
            string userChoice;
            do
            {
                Console.WriteLine(playerName + ", please enter what you would like to choose, rock, paper, scissors, lizard, or spock.");
                userChoice = Console.ReadLine();
            } while ((userChoice.ToLower() != "rock") && (userChoice.ToLower() != "paper") && (userChoice.ToLower() != "scissors") && (userChoice.ToLower() != "lizard") && (userChoice.ToLower() != "spock"));
            int assignedValue = AssignValue(userChoice);
            playerChoice = userChoice;
            return assignedValue;
        }

        public int ComputerChoice()
        {
            Random rnd = new Random();
            int computerChoiceValue = rnd.Next(0, 5);
            if (computerChoiceValue == 0)
            {
                playerChoice = "rock";
            }
            if (computerChoiceValue == 1)
            {
                playerChoice = "paper";
            }
            if (computerChoiceValue == 2)
            {
                playerChoice = "scissors";
            }
            if (computerChoiceValue == 3)
            {
                playerChoice = "spock";
            }
            if (computerChoiceValue == 4)
            {
                playerChoice = "lizard";
            }
            Console.WriteLine("The computer chose " + playerChoice);
            return computerChoiceValue;
        }

        public int AssignValue(string userChoice)
        {
            int assignedValue = 0;
            if (userChoice.ToLower() == "rock")
            {
                assignedValue = 0;
            }
            if (userChoice.ToLower() == "paper")
            {
                assignedValue = 1;
            }
            if (userChoice.ToLower() == "scissors")
            {
                assignedValue = 2;
            }
            if (userChoice.ToLower() == "spock")
            {
                assignedValue = 3;
            }
            if (userChoice.ToLower() == "lizard")
            {
                assignedValue = 4;
            }
            return assignedValue;
        }

        public void PrintRoundWinner(string playerOneChoice, string playerTwoChoice)
        {
            Console.WriteLine(playerOneChoice + " beats " + playerTwoChoice);
        }

        public int DetermineWinner(int assignedValuePlayerOne, int assignedValuePlayerTwo)
        {
            int n = (5 + assignedValuePlayerOne - assignedValuePlayerTwo) % 5;
            if ((n == 1) || (n == 3))
            {
                return 1;
            }
            else if ((n == 2) || (n == 4))
            {
                return 2;
            }
            return -1;
        }

        public void DisplayWinner(string playerOneName, string playerTwoName)
        {
            Console.WriteLine(playerOneName + " has 3 wins, and has defeated " + playerTwoName);
            Console.ReadLine();
        }
    }
}
