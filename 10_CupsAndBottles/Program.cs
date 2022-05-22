using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _10_CupsAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numberOfCups = new Queue<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse));
            Stack<int> numberOfBottles = new Stack<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse));
        }
    }
}
