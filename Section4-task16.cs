using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sectiion4_task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type word!");
            string input = Console.ReadLine();
            char[] iarr = input.ToCharArray();

            string reversedstring = "";
            for (int i = iarr.Length - 1; i >= 0; i--)
            {

                reversedstring = reversedstring + iarr[i];

            }
            Console.WriteLine(reversedstring);
        }
    }
}
