using System;
using System.Collections.Generic;
using System.Linq;

namespace _01__Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cmndLine = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = cmndLine[0];
            int s = cmndLine[1];
            int x = cmndLine[2];

            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            Stack<int> stak = new Stack<int>();

            if (s < n)
            {
                for (int i = 0; i < n - s; i++)
                {
                    stak.Push(numbers[i]);
                }
            }

            if (stak.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (stak.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stak.Min());
            }

        }
    }
}
