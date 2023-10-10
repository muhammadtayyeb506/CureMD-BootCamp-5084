using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3_task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, };
            Console.WriteLine("please enter the number you want to search !");
            int n = int.Parse(Console.ReadLine());
            int t = 0;
            for (int i = 0 ;  i < data.Length ; i++) 
                {
                int a = data[i];
                if( a==n)
                    {
                    t = t +1;
                    Console.WriteLine(n + " is present in given data");
                    break;
                   
                    }
               
                }
            if (t==0)
            {
                Console.WriteLine(n + " is not present in given data");
            }
        }
    }
}
