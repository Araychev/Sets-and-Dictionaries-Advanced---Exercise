using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            FillSet(elements, n);
            Console.WriteLine(string.Join(" ", elements));
        }

      static SortedSet<string> FillSet(SortedSet<string> elements, int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ");

                for (int j = 0; j < input.Length; j++)
                {
                    elements.Add(input[j]);
                }
            }
            return elements;
        }
    }
}
