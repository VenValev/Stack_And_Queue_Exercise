using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stak = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] cmnd = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
                if (cmnd[0] == 1)
                {
                    stak.Push(cmnd[1]);
                }
                else if (cmnd[0] == 2 && stak.Count > 0)
                {
                    stak.Pop();
                }
                else if (cmnd[0] == 3 && stak.Count > 0)
                {
                    Console.WriteLine(stak.Max());
                }
                else if (cmnd[0] == 4 && stak.Count > 0)
                {
                    Console.WriteLine(stak.Min());
                }
            }

            string[] s = new string[stak.Count];
            int d = stak.Count();
            for (int i = 0; i < d; i++)
            {
                s[i] = stak.Peek().ToString();
                stak.Pop();
            }

            Console.WriteLine(string.Join(", ", s));
            Console.WriteLine();

        }
    }
}
