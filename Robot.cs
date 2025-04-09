using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written By Bobbi Lovstad
// 4/8/25

namespace Homework_7
{
    public class Robot
    {
        public static bool JudgeCircle (string moves)
        {
            int x = 0; // Horizontal Position
            int y = 0; // Vertical Posiiton 

            // Process in the charcter in the moves string

            for ( int i = 0; i < moves.Length; i++)
            {
                char move = moves[i];
                if (move == 'U') y++;
                else if (move == 'D') y--;
                else if (move == 'L') x--;
                else if (move == 'R') x++;
            }

            // Check if the robot is back at the orgin

            return x == 0 && y == 0;
        }

        public static void Main (string[] args)
        {
            string moves = 'URDL';
            bool result = JudgeCircle(moves);
            Console.WriteLine('Results to Orgin' + result);
        }
    }
  

    
}
