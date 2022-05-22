using System;
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
            int br = 0;


            while(true)
            {
                cmnd = Console.ReadLine();
                int currentTime = greenLightTime;

                if (cmnd == "green")
                {
                    while (currentTime > 0)
                    {
                        string c = cars.Dequeue();
                        currentTime = currentTime - c.Length;
                        if(currentTime <= 0)
                        {
                            if((freeWindow + currentTime) >= 0)
                            {
                                br++;
                            }
                            else
                            {
                                int positionOfCrash = c.Length - (currentTime + freeWindow);
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{c} was hit at {c[positionOfCrash]}");
                                break;
                            }
                        }
                        br++;
                    }
                }
                else if( cmnd == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{br} total cars passed the crossroads.");
                    break;
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
