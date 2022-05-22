using System;
using System.Collections.Generic;

namespace _06_SongsQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> playlist = new Queue<string>(Console.ReadLine()
                .Split(", "));

            while (playlist.Count > 0)
            {
                string[] cmnd = Console.ReadLine().Split(' ', 2);

                if (cmnd[0] == "Play")
                {
                    playlist.Dequeue();
                }
                else if (cmnd[0] == "Add")
                {

                    if (playlist.Contains(cmnd[1]))
                    {
                        Console.WriteLine($"{cmnd[1]} is already contained!");
                    }
                    else
                    {
                        playlist.Enqueue(cmnd[1]);

                    }
                }
                else if (cmnd[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", playlist));
                }

                if (playlist.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
            }
        }
    }
}
