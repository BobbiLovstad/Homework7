using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written By Bobbi Lovstad
// 04/8/25

namespace Homework_7
{
    public class Segment
    {
        public static int CountSegment(string s)
        {
            int count = 0; // Count the Segments
            bool inSegment = false; // keep track of if we are in the segment

            // loop through each character in the string 

            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];

                if (c != '')
                {
                    // If we are not already in the segment

                    if (! inSegment)
                    {
                        count++;
                        inSegment = true;
                    }
                }
                else
                {
                    // if we hit a space we are no longer in the segment

                    inSegment = false;
                }
            }
            return count;
        }
        public static void Main(string[]args)
        {
            string input = 'hello world';
            int result = CountSegment(input);
            Console.WriteLine('number of segments' + result);
        }
    }
   

}
