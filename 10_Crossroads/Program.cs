﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightTime = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            String cmnd;
            Queue<string> cars = new Queue<string>();
            Queue<char> lastCar = new Queue<char>();
            //Stack<char> s = new Stack<char>();

            while((cmnd = Console.ReadLine()) != "END")
            {
                if(cmnd == "green")
                {
                    for(int i = 0; i < greenLightTime; i++)
                    {
                        cars.Dequeue();
                    }
                    if(cars.Count > 0)
                    {
                        char[] c = cars.Dequeue().ToCharArray();
                        FillingTheLastCarQueue(lastCar, c);
                    }
                }
                else
                {
                    cars.Enqueue(cmnd);
                }
            }
        }

         static void FillingTheLastCarQueue(Queue<char> lastCar, char[] c)
        {
            for(int i = 0; i < c.Length; i++)
            {
                lastCar.Enqueue(c[i]);
            }
        }
    }
}
