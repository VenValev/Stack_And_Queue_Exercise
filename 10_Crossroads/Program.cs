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
            bool flag = false;

            while(true)
            {
                cmnd = Console.ReadLine();
                int timeNeeded = greenLightTime;

                if (cmnd == "green")
                {
                    while (timeNeeded > 0 && cars.Count > 0)
                    {
                        string c = cars.Dequeue();
                        timeNeeded = timeNeeded - c.Length;
                        if(timeNeeded <= 0)
                        {
                            if((freeWindow - Math.Abs(timeNeeded)) >= 0)
                            {
                                br++;
                                continue;
                            }
                            else
                            {
                                int positionOfCrash = c.Length - Math.Abs((freeWindow - Math.Abs(timeNeeded)));
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{c} was hit at {c[positionOfCrash]}.");
                                flag = true;
                                break;
                            }
                        }
                        br++;
                    }
                    if (flag) break;
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
    }
}
