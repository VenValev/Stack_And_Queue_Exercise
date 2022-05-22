using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());

            List<int> orders = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Queue<int> foodOrders = new Queue<int>(orders);
            int fo = foodOrders.Count;
            Console.WriteLine(foodOrders.Max());

            for (int i = 0; i < fo; i++)
            {
                if (food >= foodOrders.Peek())
                {
                    food -= foodOrders.Peek();
                    foodOrders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (foodOrders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", foodOrders)}");

            }


        }
    }
}
