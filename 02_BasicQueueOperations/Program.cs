using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_BasicQueueOperations
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
            Queue<int> qu = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                qu.Enqueue(numbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                qu.Dequeue();
            }

            if (qu.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (qu.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(qu.Min());
            }
        }
    }
}
