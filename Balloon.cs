using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Written By Bobbi Lovstad
// 4/8/25
namespace Homework_7
{
    public class Baloon
    {
        public int NumBaloon(string text)
        {
            // create counters for characters in baloon 

            int b = 0, a = 0, l = 0, o = 0, n = 0;

            // Loop through each character in the input string 

            for ( int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (c == 'b') b++;
                else if (c == 'a') a++;
                else if (c == 'l') l++;
                else if (c == 'n') n++;
                else if (c == 'o') o++;
                
            }

            // l and o appear twice in baloon 

            l / = 2;
            0 / = 2;

            // Number of full baloons

            int min = b;

            if (a < min) min = a;
            if (l < min) min = l;
            if (o < min) min = o;
            if (n < min) min = n;

            return min;


        }
    }
}
