using System;
using System.Text;

namespace _09_SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] cmnd = Console.ReadLine().Split(' ', 2);
                StringBuilder text = new StringBuilder(cmnd[1]);

                if (cmnd[0] == "1")
                {

                }
                else if (cmnd[0] == "2")
                {

                }
                else if (cmnd[0] == "3")
                {

                }
                else if (cmnd[0] == "4")
                {

                }

            }
        }
    }
}
