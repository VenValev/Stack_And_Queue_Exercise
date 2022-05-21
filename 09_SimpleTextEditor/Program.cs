using System;
using System.Collections.Generic;
using System.Text;

namespace _09_SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> sText = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmnd = Console.ReadLine().Split(' ', 2);
                

                if (cmnd[0] == "1")
                {
                    text.Append(cmnd[1]);
                }
                else if (cmnd[0] == "2")
                {

                }
                else if (cmnd[0] == "3")
                {
                    int c = int.Parse(cmnd[1]);
                    Console.WriteLine(text[c-1]);
                }
                else if (cmnd[0] == "4")
                {

                }

            }
        }
    }
}
