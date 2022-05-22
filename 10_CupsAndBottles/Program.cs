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
                int currentCup = capacityOfCups.Peek();
                int currentBottle = capacityOfBottles.Peek();

                if (capacityOfCups.Count == 0 && capacityOfBottles.Count > 0)
                {

                }
                else if (capacityOfBottles.Count == 0 && capacityOfCups.Count > 0)
                {

                }
                else
                {
                    while(currentCup > 0)
                    {
                        currentCup -= capacityOfBottles.Pop();
                        if(currentCup < 0)
                        {
                            wastedWater += Math.Abs(currentCup);
                        }
                    }
                }
            }
        }
    }
}
