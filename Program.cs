using System;
namespace Dice_Game
{
    class Program
    { 
    static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;    

Random random = new Random();

            for (int i = 0; i < 10 ; i++)
            {
             
                Console.WriteLine("Press any key to roll the dice ");
           
                Console.ReadKey();
                playerRandomNum= random.Next(5,9);  
               
                Console.WriteLine("you rolled a " + playerRandomNum);
           
              Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                    enemyRandomNum= random.Next(5,9);
                Console.WriteLine("enemy Ai rolled a\" + enemyRandomNum");
             
             if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
             else if(enemyRandomNum < enemyPoints)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");

                }
             else
                {
                    Console.WriteLine("that is a Draw Game.");
                }
                Console.WriteLine("The score is now - player :"+ playerPoints + ".Enemy : " + enemyPoints + "." );
                Console.WriteLine();

            }
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("you win");
            }

            else if(playerPoints < enemyPoints)
            {
                Console.WriteLine("you loose");

            }
            else {
                Console.WriteLine("it is a draw game");
                   }
            Console.ReadKey();
        }
    }
}