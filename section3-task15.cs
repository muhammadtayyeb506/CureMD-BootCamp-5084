using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3_task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the hiegth of traiangle!");
            int input = int.Parse(Console.ReadLine());
            int i = 0, j = 0;
            for (i = 1; i <= input; i++)
            {
                for (j = 1; j <= input; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");
            }Console.ReadLine();
        }
    }
}
