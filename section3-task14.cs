using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3_task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the hiegth of traiangle!");
            int input = int.Parse(Console.ReadLine());
            int i = 0, j = 0;
            for(i = 1; i<=input; i++)  
            {
                for(j = 0; j<=input; j++)
                {
                    if(j<i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine("");
            }
        }
    }
}
