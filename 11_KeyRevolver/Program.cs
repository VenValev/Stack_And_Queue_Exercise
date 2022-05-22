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
            int sizeOfGunBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine()
                .Split(' ')
                .Select(int.Parse));
            int valueOfInteligence = int.Parse(Console.ReadLine());
            int expences = 0;

            while (true)
            {
                
                if(bullets.Count == 0 && locks.Count > 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    break;
                }
                else if(locks.Count == 0)
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${valueOfInteligence - expences}");
                }
            }
        }
    }
}
