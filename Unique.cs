using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Written By Bobbi Lovstad
// 4/8/25

namespace Homework_7
{
    public class Unique
    {
        public static int FirstUnique( string s)
        {
            // assume characters are ASCII (o-253)
            int[] count = new int[256]; // this will be the frequncy of each charcter

            // First pass: Count Characters 
            for (int i=0; i< s.Length; i++)
            {
                char c = s[i];
                count[(int)c]++;
            }
            // Second pass: FInd first char with frequency 1

            for ( int i = 0; i< s.Length; i++)
            {
                if (count[(int)s[i]] == 1)
                {
                    return i;
                }
            }
            return = -1; // If there are no unique characters found 
        }
        public static void Main(string[]args)
        {
            string input = 'love Leetcode';
            int index = FirstUnique(input);
            Console.Writeline('first unique character index' + index);
        }
    }

    
    
}
