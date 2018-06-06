using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, player one. Please enter your name");
            Player playerOne = new Player();
            bool determineNumberOfPlayers = playerOne.DetermineNumberOfPlayers();
            if (determineNumberOfPlayers)
            {
                Console.WriteLine("Enter a name for the computer");
                Player computer = new Player();
                do
                {
                    int playerOneValue = playerOne.MakeChoice();
                    int computerValue = computer.ComputerChoice();
                    int determineWinnerValue = computer.DetermineWinner(playerOneValue, computerValue);
                    if (determineWinnerValue == 1)
                    {
                        playerOne.PrintRoundWinner(playerOne.playerChoice, computer.playerChoice);
                        playerOne.wins++;
                    }
                    else if (determineWinnerValue == 2)
                    {
                        playerOne.PrintRoundWinner(computer.playerChoice, playerOne.playerChoice);
                        computer.wins++;
                    }
                    else
                    {
                        Console.WriteLine("Tie!");
                        Console.ReadLine();
                    }
                } while ((playerOne.wins < 3) && (computer.wins < 3)) ;
                    if (playerOne.wins == 3)
                {
                    playerOne.DisplayWinner(playerOne.playerName, computer.playerName);
                }
                else if (computer.wins == 3)
                {
                    computer.DisplayWinner(computer.playerName, playerOne.playerName);
                } 
            }
            else
            {
                Console.WriteLine("What is player two's name?");
                Player playerTwo = new Player();
                do
                {
                    int playerOneValue = playerOne.MakeChoice();
                    int playerTwoValue = playerTwo.MakeChoice();
                    int determineWinnerValue = playerOne.DetermineWinner(playerOneValue, playerTwoValue);
                    if (determineWinnerValue == 1)
                    {
                        playerOne.PrintRoundWinner(playerOne.playerChoice, playerTwo.playerChoice);
                        playerOne.wins++;
                    }
                    else if (determineWinnerValue == 2)
                    {
                        playerOne.PrintRoundWinner(playerTwo.playerChoice, playerOne.playerChoice);
                        playerTwo.wins++;
                    }
                    else
                    {
                        Console.WriteLine("Tie!");
                        Console.ReadLine();
                    }
                } while ((playerOne.wins < 3) && (playerTwo.wins < 3)) ; 
                    if (playerOne.wins == 3)
                {
                    playerOne.DisplayWinner(playerOne.playerName, playerTwo.playerName);
                }
                else if (playerTwo.wins == 3)
                {
                    playerTwo.DisplayWinner(playerTwo.playerName, playerOne.playerName);
                }
            }
        }
    }
}
