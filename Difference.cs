using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written By Bobbi Lovstad
// 4/8/25
namespace Homework_7

public static char FindTheDifference ( string s, string t)
{
    int sumsS = 0;
    int sumsT = 0;

    // sum ASC II values of all characters in s 

    for ( int i = 0; i < s.Length; i++)
    {
        sumsS += s[i];
    }
    // sum ASC II values of all characters in T

    for ( int i = 0; i < t.Length; i ++)
    {
        sumsT += t[i];
    }

    // The difference is the added character 

    return (char)(sumsT - sumsS);

}

public static void Main(string[] args)
{
    string s = 'abcd';
    string t = 'abcde';
    char result = FindTheDifference(s, t);
    Console.WriteLine('added character' + result);
}



