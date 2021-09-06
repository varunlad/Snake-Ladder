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
            int player1 = 0;
            Random random = new Random();
            Random random1 = new Random();

            int x = random.Next(1, 6);
            int y = random.Next(0, 7);
            Console.WriteLine("Random roll is : " + y);
            if (x == y)
            {
                Console.WriteLine("player 1 roll is : " + x);
                Console.WriteLine("Player Has Climb on Ladder");
                player1 = x + x;
            }
            else if (y == 0)
            {
                Console.WriteLine("player 1 roll is : " + x);
                Console.WriteLine("Player Has stepped on snake");
                player1 = x - x;
            }
            else
            {
                Console.WriteLine("player 1 roll is : " + x);

            }
            Console.ReadLine();
        }
    }
}
