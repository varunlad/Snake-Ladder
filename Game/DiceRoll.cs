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
            while (player1 <= 100)
            {
                int x = random.Next(1, 6);
                Console.WriteLine("  player 1 roll is : " + x);
                player1 = player1 + x;
                Console.WriteLine("The players position is : " + player1);

            }
            Console.ReadLine();
            
        }
    }
}
