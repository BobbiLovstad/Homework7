using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written by Bobbi Lovstad
// 4/8/25

namespace Homework_7
{
    public class Merge
    {
        public static string MergeAlt(string word1, string word2)
        {
            // create a charcter arrary large enought to hold the result 
            int totalLength = word1.Length + word2.Length;
            char[] merged = new char[totalLength];

            int i = 0; // index for word1
            int j = 0; // index for word2
            int k = 0; // index for merged array

            // Alternate between charaters from word1 and word2

            while (i < word1.Length && j < word2.Length)
            {
                merged[k++] = word1[i++];
                merged[k++] = word2[j++];
            }

            // Append remaining characters in word 1

            while ( i < word1.Length)
            {
                merged[k++] = word1[i++];
            }

            // Append remaining characters in word 2

            while (j < word1.Length)
            {
                merged[k++] = word2[j++];
            }

            // Convert character array to string manually 

            string result = '';

            for( int m = 0; m <totalLength; m++)
            {
                result += merged[m]; // This may not increase efficiency 
            }

            return result;





        }

        public static void Main (string[] args)
        {
            string word1 = 'abcd';
            string word2 = 'prqst';
            string merged = MergeAlt(word1, word2);

            Console.WriteLine('merged string' + merged);

        }
