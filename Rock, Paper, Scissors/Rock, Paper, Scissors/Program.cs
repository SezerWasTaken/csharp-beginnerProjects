using System;

class Program
{

    static void Main(string[] args)
    {
        Console.Title = "Rock, Paper, Scissors";

        string inputPlayer, inputGpu;
        int randomInt;

        bool playAgain = true;
            
        while (playAgain)
        {
            int ScorePlayer = 0;
            int ScoreGpu = 0;

            while (ScorePlayer < 3 && ScoreGpu < 3) 
            {
                Console.Write("Choose between Rock, Paper, Scissors: ");
                inputPlayer = Console.ReadLine();

                Random rnd = new Random();
                randomInt = rnd.Next(1, 4);

                switch (randomInt)
                {
                    case 1:
                        inputGpu = "Rock";
                        Console.WriteLine("Gpu choose Rock");
                        if (inputPlayer == "Rock")
                        {
                            Console.WriteLine("Draw!! \n\n");
                        }
                        if (inputPlayer == "Paper")
                        {
                            Console.WriteLine("Player Wins!! \n\n");
                            ScorePlayer++;
                        }
                        if (inputPlayer == "Scissors")
                        {
                            Console.WriteLine("Gpu Wins!! \n\n");
                            ScoreGpu++;
                        }
                        break;
                    case 2:
                        inputGpu = "Paper";
                        Console.WriteLine("Gpu choose Paper");
                        if (inputPlayer == "Paper")
                        {
                            Console.WriteLine("Draw!! \n\n");
                        }
                        if (inputPlayer == "Rock")
                        {
                            Console.WriteLine("Player Wins!! \n\n");
                            ScorePlayer++;
                        }
                        if (inputPlayer == "Scissors")
                        {
                            Console.WriteLine("Gpu Wins!! \n\n");
                            ScoreGpu++;
                        }
                        break;
                    case 3:
                        inputGpu = "Scissors";
                        Console.WriteLine("Gpu choose Scissors");
                        if (inputPlayer == "Scissors")
                        {
                            Console.WriteLine("Draw!! \n\n");
                        }
                        if (inputPlayer == "Rock")
                        {
                            Console.WriteLine("Player Wins!! \n\n");
                            ScorePlayer++;
                        }
                        if (inputPlayer == "Paper")
                        {
                            Console.WriteLine("Gpu Wins!! \n\n");
                            ScoreGpu++;
                        }
                        break;
                }
                Console.WriteLine("Gpu Score: {0} \t\t Player Score: {1}",ScoreGpu,ScorePlayer);

                if (ScorePlayer == 3)
                {
                    Console.WriteLine("Player Wins!!");
                }
                else if(ScoreGpu == 3) 
                {
                    Console.WriteLine("Gpu Wins!!");
                }
            }
            Console.Write("Do you want to play again? (y/n): ");
            string loop = Console.ReadLine();

            if (loop == "y")
            {
                playAgain = true;
                Console.Clear();
            }
            else
            {
                playAgain = false;
                Console.Clear();
            }
        }
    }
}