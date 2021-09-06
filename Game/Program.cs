using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = 0, dice = 0, player2 = 0;
            Random random = new Random();
            Random random1 = new Random();
            Random random2 = new Random();
            while (player1 < 100 && player2 < 100)
            {
                int x = random.Next(1, 6);
                int z = random.Next(1, 6);
                dice = dice + 1;
                int y = random1.Next(0, 7);
                int w = random2.Next(0, 7);


                if (x == y)
                {
                    Console.WriteLine("player 1 roll is : " + x);
                    Console.WriteLine("Player Has Climb on Ladder");
                    player1 = player1 + x + x;
                }
                else if (y == 0)
                {
                    Console.WriteLine("player 1 roll is : " + x);
                    Console.WriteLine(" Player Has stepped on snake");
                    if (player1 != 0)
                        player1 = player1 - x;
                }
                else
                {
                    Console.WriteLine("player 1 roll is : " + x);
                    player1 = player1 + x;
                }


                Console.WriteLine("The players position is : " + player1);
                Console.WriteLine("The number of times the dice was rooled : " + dice);



                if (z == w)
                {
                    Console.WriteLine("player 2 roll is : " + z);
                    Console.WriteLine("Player Has Climb on Ladder");
                    player2 = player1 + z + z;
                }
                else if (w == 0)
                {
                    Console.WriteLine("player 2 roll is : " + z);
                    Console.WriteLine(" Player Has stepped on snake");
                    if (player2 != 0)
                        player2 = player1 - z;
                }
                else
                {
                    Console.WriteLine("player 2 roll is : " + x);
                    player2 = player1 + z;
                }


                Console.WriteLine("The players position is : " + player2);
                Console.WriteLine("The number of times the dice was rooled : " + dice);


            }
            if (player1 > player2)
            {
                Console.WriteLine("!!!!Player 1 has won the game!!!!");
            }
            else
            {
                Console.WriteLine("!!!!Player 2 has won the game!!!!");
            }

            Console.ReadLine();
        }
    }
}
