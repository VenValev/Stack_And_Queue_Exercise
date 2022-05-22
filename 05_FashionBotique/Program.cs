using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_FashionBotique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> boxOfClothes = new Stack<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int rack = 1;
            int boc = boxOfClothes.Count;

            /*for(int i = 0; i < boc; i++)
            {
                int currSum = sum + boxOfClothes.Peek();

                if(currSum <= rackCapacity)
                {
                    sum += boxOfClothes.Peek();
                    boxOfClothes.Pop();
                }
                if(currSum == rackCapacity)
                {
                    sum = 0;
                    if(boxOfClothes.Count > 0)
                    {
                        rack++;
                    }
                }
                else if(currSum > rackCapacity)
                {
                    sum = 0;
                    rack++;
                    i--;
                    //boxOfClothes.Pop();
                }
            }*/

            while (boxOfClothes.Count > 0)
            {
                int currSum = sum + boxOfClothes.Peek();

                if (currSum <= rackCapacity)
                {
                    sum += boxOfClothes.Peek();
                    boxOfClothes.Pop();
                }
                if (currSum == rackCapacity)
                {
                    sum = 0;
                    if (boxOfClothes.Count > 0)
                    {
                        rack++;
                    }
                }
                else if (currSum > rackCapacity)
                {
                    sum = 0;
                    rack++;
                    //boxOfClothes.Pop();
                }
            }


            Console.WriteLine(rack);
        }
    }
}
