using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sectiion4_task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type word!");
            int input = int.Parse(Console.ReadLine());
            int[] iarr = new int[2];
            iarr[0] = 1;
            for (int i = 0; i <=input ; i++)
            {
                iarr[1] = i;
                iarr[0] = iarr[0] + iarr[1];
                Console.WriteLine(iarr[0]); 
            }
            Console.ReadLine();
       
        }
    }
}
