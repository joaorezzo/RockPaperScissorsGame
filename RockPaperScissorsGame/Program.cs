using System;

namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // 1=rock. 2=paper. 3=scissors
            bool playAgain = true;
            String player;
            String computer;

            while (playAgain) //playAgain == true
            {
                player = ""; //forma de reset toda vez que "playAgain"
                computer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") //validacao, somente passar quando der um desses valores, se n repete
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();

                
                }
           
                switch (random.Next(1, 4)) //numero random de 1 a 4, excluindo o 4
                {
                    case 1:
                        computer = "ROCK";
                        break;

                    case 2:
                        computer = "PAPER";
                        break;

                    case 3:
                        computer = "SCISSORS";
                        break;

                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":

                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("Computer won");
                        }
                        else
                        {
                            Console.WriteLine("You won!");
                        }
                        break;

                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("You won!");
                        }
                        else
                        {
                            Console.WriteLine("Computer won");
                        }
                        break;

                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("Computer won");
                        }
                        else
                        {
                            Console.WriteLine("You won!");
                        }                   
                        break;
                }
            }


        }
    }
}
