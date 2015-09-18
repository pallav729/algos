// https://www.hackerrank.com/challenges/sherlock-and-anagrams

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
        static void Main(string[] args)
        {
            int inputs = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < inputs; i++)
            {
                Console.WriteLine(AllAnanagramPairs(Console.ReadLine()));
            }
        }

        static int AllAnanagramPairs(string S)
        {
            if (S.Length <= 1)
            {
                return 0;
            }

            int count = 0;
            // first loop for length
            for (int i = 1; i < S.Length; i++)
            {
                for (int j = 0; j < S.Length - i; j++)
                {
                    var first = S.Substring(j, i);
                    for (int k = j + 1; k + i <= S.Length; k++)
                    {
                        var second = S.Substring(k, i);

                        if (AreAnagrams(first, second))
                        {
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        static bool AreAnagrams(string a, string b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            var dict1 = GetCounts(a);
            var dict2 = GetCounts(b);

            foreach (var k in dict1)
            {
                if (dict2.ContainsKey(k.Key) && dict1[k.Key] == dict2[k.Key])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        static Dictionary<char, int> GetCounts(string a)
        {
            var dict = new Dictionary<char, int>();
            foreach (char c in a)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }

            return dict;
        }
    }
