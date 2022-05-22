using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int sizeOfMagazine = int.Parse(Console.ReadLine());
            Stack<int> numberOfBullets = new Stack<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse));
            Queue<int> numberOfLocks = new Queue<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse));
            int valueOfInteligence = int.Parse(Console.ReadLine());
            int expences = 0;
            int magazine = sizeOfMagazine;

            while (true)
            {
                
                if(numberOfBullets.Count == 0 && numberOfLocks.Count > 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {numberOfLocks.Count}");
                    break;
                }
                else if(numberOfLocks.Count == 0)
                {
                    Console.WriteLine($"{numberOfBullets.Count} bullets left. Earned ${valueOfInteligence - expences}");
                    break;
                }
                else
                {
                    int bullet = numberOfBullets.Pop();
                    if(bullet <= numberOfLocks.Peek() && magazine > 0)
                    {
                        Console.WriteLine("Bang!");
                        numberOfLocks.Dequeue();
                        magazine--;
                        expences += priceOfBullet;
                    }
                    else if(magazine > 0)
                    {
                        Console.WriteLine("Ping!");
                        magazine--;
                        expences += priceOfBullet;
                    }
                    if(magazine == 0 && numberOfBullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        magazine = sizeOfMagazine;
                    }
                }
            }
        }
    }
}
