// https://www.hackerrank.com/challenges/bigger-is-greater
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        var inputs = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < inputs; i++)
        {
            NextString();
        }
    }
    static void NextString()
    {
        var input = Console.ReadLine();

        if (input.Length == 1)
        {
            Console.WriteLine("no answer");
            return;
        }

        int smaller = -1;
        int larger = -1;
        int distance = Int32.MaxValue;

        for (int i = input.Length - 2; i >= 0; i--)
        {
            for (int j = i + 1; j < input.Length; j++)
            {
                if (input[i] < input[j] && (input[j] - input[i]) < distance)
                {
                    smaller = i;
                    larger = j;
                    distance = input[j] - input[i];
                }
            }

            if (smaller != -1)
            {
                break;
            }
        }

        if (smaller == -1)
        {
            Console.WriteLine("no answer");
        }
        else
        {
            Console.WriteLine(NextLexically(input, smaller, larger));
        }
    }

    static string NextLexically(string s, int i, int j)
    {
        var charArr = s.ToCharArray();
        var temp = charArr[i];
        charArr[i] = charArr[j];
        charArr[j] = temp;

        s = new string(charArr);
        var prefix = s.Substring(0, i+1);
        var suffix = s.Substring(i+1);
        var suffixArrary = new List<char>(suffix.ToCharArray());
        suffixArrary.Sort();
        suffix = string.Join("", suffixArrary.ToArray()); ;

        return prefix + suffix;
    }
}