using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _08_BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string input = Console.ReadLine();
            Stack<char> parenthesStack = new Stack<char>();
            foreach (var symbol in input)
            {
                if (parenthesStack.Any())
                {
                    char check = parenthesStack.Peek();
                    if (check == '{' && symbol == '}')
                    {
                        parenthesStack.Pop();
                        continue;
                    }
                    else if (check == '[' && symbol == ']')
                    {
                        parenthesStack.Pop();
                        continue;
                    }
                    else if (check == '(' && symbol == ')')
                    {
                        parenthesStack.Pop();
                        continue;
                    }
                }
                parenthesStack.Push(symbol);
            }
            Console.WriteLine(!parenthesStack.Any() ? "YES" : "NO");*/

            String parentheses = Console.ReadLine();
            Stack<char> sPare = new Stack<char>();

            for(int i= 0; i < parentheses.Length; i++)
            {
                char c = parentheses[i];

                if (sPare.Count != 0)
                {
                    
                    if (c == ')' && sPare.Peek() == '(')
                    {
                        sPare.Pop();
                        continue;
                    }
                    else if (c == ']' && sPare.Peek() == '[')
                    {
                        sPare.Pop();
                        continue;
                    }
                    else if (c == '}' && sPare.Peek() == '{')
                    {
                        sPare.Pop();
                        continue;
                    }
                }
                sPare.Push(c);
                
            }

            if(sPare.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
