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
            int player1 = 0, dice = 0;
            Random random = new Random();
            Random random1 = new Random();
            while (player1 < 100)
            {
                int x = random.Next(1, 6);
                dice = dice + 1;
                int y = random.Next(0, 7);


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
                    player1 = player1 + x - x - x;
                }
                else
                {
                    Console.WriteLine("player 1 roll is : " + x);
                    player1 = player1 + x;
                }


                Console.WriteLine("The players position is : " + player1);
                Console.WriteLine("The number of times the dice was rooled : " + dice);

            }
            Console.ReadLine();
        }
    }
}
