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
            Stack<string> historyOfText = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] cmnd = Console.ReadLine().Split(' ', 2);
                

                if (cmnd[0] == "1")
                {
                    text.Append(cmnd[1]);
                    historyOfText.Push(text.ToString());
                }
                else if (cmnd[0] == "2")
                {
                    int lenght = int.Parse(cmnd[1]);
                    int startIndex = (text.Length) - lenght;
                    text.Remove(startIndex, lenght);
                    historyOfText.Push(text.ToString());
                }
                else if (cmnd[0] == "3")
                {
                    int indexOfChar = int.Parse(cmnd[1]) - 1;
                    Console.WriteLine(text[indexOfChar]);
                }
                else if (cmnd[0] == "4")
                {
                    historyOfText.Pop();
                    text.Clear();
                    if(historyOfText.Count > 0)
                    {
                        text.Append(historyOfText.Peek());
                    }
                }
            }
        }
    }
}
