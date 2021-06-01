using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            FildDictionary(numbers, n);
            PrintResult(numbers);

        }

        static void PrintResult(Dictionary<int, int> numbers)
        {
            
            foreach (var item in numbers)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }

        static Dictionary<int, int> FildDictionary(Dictionary<int, int> numbers, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }
                numbers[number]++;
            }

            return numbers;
        }
    }
}
