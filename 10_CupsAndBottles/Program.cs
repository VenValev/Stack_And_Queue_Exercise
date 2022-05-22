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
            Queue<int> capacityOfCups = new Queue<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse));
            Stack<int> capacityOfBottles = new Stack<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse));
            int wastedWater = 0;

            while(true)
            {
                
                int currentCup;
                int currentBottle = 0; //N Capacity
                
                    

                if (capacityOfCups.Count == 0 && capacityOfBottles.Count > 0)
                {
                    Console.Write("Bottles: ");
                    Console.Write(String.Join(' ', capacityOfBottles));
                    Console.WriteLine();
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    break;
                }
                else if (capacityOfBottles.Count == 0 && capacityOfCups.Count > 0)
                {
                    Console.Write("Cups: ");
                    Console.Write(String.Join(' ', capacityOfCups));
                    Console.WriteLine();
                    Console.WriteLine($"Wasted litters of water: {wastedWater}");
                    break;
                }
                else
                {
                    currentCup = capacityOfCups.Peek();
                    currentBottle = capacityOfBottles.Peek();

                    while (currentCup > 0 && capacityOfBottles.Count > 0)
                    {
                        currentCup -= capacityOfBottles.Pop();
                        if(currentCup <= 0)
                        {
                            wastedWater += Math.Abs(currentCup);
                            capacityOfCups.Dequeue();
                        }
                    }
                }
            }
        }
    }
}
