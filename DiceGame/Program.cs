using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerNum;
            Random random = new Random();

            int aiNum;

            int playerPoints = 0;
            int aiPoints = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();
                
                playerNum = random.Next(1,7);
                Console.WriteLine("You rolled a " + playerNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                aiNum = random.Next(1,7);
                Console.WriteLine("Enemy AI rolled a " + aiNum);

                if(playerNum > aiNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");

                }
                else if (playerNum < aiNum)
                {
                    
                    aiPoints++;
                    Console.WriteLine("AI wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
                Console.WriteLine("The score is now - player : " + playerPoints + ". AI : " + aiPoints + ".");
                Console.WriteLine();

            }

            if(playerPoints > aiPoints)
            {
                Console.WriteLine("You win!");
            }
            else if(playerPoints < aiPoints)
            {
                Console.WriteLine("AI wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }




            Console.ReadKey();



        }


    }




}