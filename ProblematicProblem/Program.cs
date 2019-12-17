using System;

namespace ProblematicProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerChoice, cpuChoice;

            int randomNum;

            bool playagain = true;

            Console.WriteLine("Lets play paper, rock, scissors. Fun fact: (In Japanese culture they call this game Jan-Ken-Pon!)\nWe're going to a score of 3!");

            Console.WriteLine();

            while (playagain == true)
            {
                int playerScore = 0;

                int cpuScore = 0;

                while (playerScore < 3 && cpuScore < 3)
                {
                    Console.Write("Please type: paper, rock, or scissors:   ");

                    playerChoice = Console.ReadLine();

                    playerChoice = playerChoice.ToLower();

                    while (playerChoice != "paper" && playerChoice != "rock" && playerChoice != "scissors")
                    {
                        Console.Write("Please choose: paper, rock, or scissors   ");

                        playerChoice = Console.ReadLine();

                        playerChoice = playerChoice.ToLower();
                    }

                    Random rnd = new Random();

                    randomNum = rnd.Next(1, 4);

                    switch (randomNum)
                    {
                        case 1:
                            cpuChoice = "paper";

                            Console.Write("The CPU chose Paper!");

                            Console.WriteLine();

                            if (playerChoice == "paper")
                            {
                                Console.WriteLine("DRAW!");
                            }

                            else if (playerChoice == "rock")
                            {
                                Console.WriteLine("YOU LOSE!! :'(");
                                cpuScore++;
                            }

                            else if (playerChoice == "scissors")
                            {
                                Console.WriteLine("YOU WIN!!");
                                playerScore++;
                            }
                            break;

                        case 2:
                            cpuChoice = "rock";
                            Console.WriteLine("The CPU chose Rock!");

                            Console.WriteLine();

                            if (playerChoice == "paper")
                            {
                                Console.WriteLine("YOU WIN!!");
                                playerScore++;
                            }

                            else if (playerChoice == "rock")
                            {
                                Console.WriteLine("DRAW!!");
                            }

                            else if (playerChoice == "scissors")
                            {
                                Console.WriteLine("YOU LOSE :'(!!");
                                cpuScore++;
                            }
                            break;

                        case 3:
                            cpuChoice = "Scissors";

                            Console.WriteLine("The CPU chose Scissors!");

                            Console.WriteLine();

                            if (playerChoice == "paper")
                            {
                                Console.WriteLine("YOU LOSE!!");
                                cpuScore++;
                            }

                            else if (playerChoice == "rock")
                            {
                                Console.WriteLine("YOU WIN!!");
                                playerScore++;
                            }

                            else if (playerChoice == "scissors")
                            {
                                Console.WriteLine("DRAW!!");
                            }
                            break;

                        default:
                            Console.WriteLine("INVALID ENTRY!!");
                            break;
                    }

                    Console.WriteLine("\nScores:\tPlayer:\t{0}\tCPU:\t{1}", playerScore, cpuScore);

                    if (playerScore == 3)
                    {
                        Console.WriteLine("Player 1 Wins!!");
                    }
                    else if (cpuScore == 3)
                    {
                        Console.WriteLine("CPU Wins!! TOO BAD!");
                    }
                }

                Console.WriteLine("Play Again? (y/n)");

                string answer = Console.ReadLine();

                answer = answer.ToLower();

                while (answer != "y" && answer != "n")
                {
                    Console.Write("Please enter a 'y' or a 'n'   ");
                    answer = Console.ReadLine();
                }

                if (answer == "y")
                {
                    playagain = true;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Thanks for playing!!");
                    Console.Write("Press Enter to continue...");
                    Console.ReadLine();
                    playagain = false;
                }
            }
        }
    }
}
