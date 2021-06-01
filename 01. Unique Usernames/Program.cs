using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> userName = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();

                if (!userName.Contains(name))
                {
                    userName.Add(name);
                }
            }

            foreach (var item in userName)
            {
                Console.WriteLine(item);
            }

        }
    }
}
