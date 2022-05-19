﻿using System;
using System.Collections.Generic;

namespace _07_Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<Pump> queue = new Queue<Pump>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                string info = Console.ReadLine();
                int amount = int.Parse(info.Split(' ')[0]);
                int distance = int.Parse(info.Split(' ')[1]);
                Pump pump = new Pump(i, amount, distance);
                queue.Enqueue(pump);
            }

            int startPosition = 0;
            int br = 0;

            for (int i = 0; i < numberOfPumps; i++)
            {

                Pump pump = queue.Peek();
                int tank = pump.amout;
                int dist = pump.distance;

                for (int j = 0; j < numberOfPumps - 1; j++)
                {
                    if (tank - dist < 0)
                    {
                        queue.Enqueue(queue.Peek());
                        queue.Dequeue();
                        br = 0;
                        break;
                    }
                    else
                    {
                        tank = tank - dist;
                        queue.Enqueue(queue.Peek());
                        queue.Dequeue();
                        tank += queue.Peek().amout;
                        dist = queue.Peek().distance;
                        br++;
                    }
                }
                if (br == numberOfPumps - 1)
                {
                    startPosition = i;
                    break;
                }


            }

            Console.WriteLine(startPosition);
        }
    }

    class Pump
    {
        private int number;
        public int amout;
        public int distance;

        public Pump(int number, int amout, int distance)
        {
            this.number = number;
            this.amout = amout;
            this.distance = distance;
        }
    }
}
}
