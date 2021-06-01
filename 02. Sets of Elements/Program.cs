using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nM = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int n = nM[0];
            int m = nM[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }
            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondSet.Add(num);
            }

            CheckSets(firstSet, secondSet);
        }

       static void CheckSets(HashSet<int> firstSet, HashSet<int> secondSet)
        {
            List<int> nums = new List<int>();

            foreach (int number in firstSet)
            {
                if (secondSet.Contains(number))
                {
                    nums.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
