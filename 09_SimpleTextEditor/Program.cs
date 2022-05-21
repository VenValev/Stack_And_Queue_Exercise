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
                    sText.Push(text.ToString());
                }
                else if (cmnd[0] == "2")
                {
                    int lenght = int.Parse(cmnd[1]);
                    int startIndex = (text.Length - 1) - lenght;
                    text.Remove(startIndex, lenght);

                    sText.Push(text.ToString());
                }
                else if (cmnd[0] == "3")
                {
                    /*text.Clear();
                    text.Append(sText.Peek());*/
                    int c = int.Parse(cmnd[1]);
                    Console.WriteLine(text[c-1]);
                }
                else if (cmnd[0] == "4")
                {
                    sText.Pop();
                    text.Clear();
                    text.Append(sText.Peek());
                }

            }
        }
    }
}
