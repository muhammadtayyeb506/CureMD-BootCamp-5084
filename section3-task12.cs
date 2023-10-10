using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section3_task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a Word!");
            string word = Console.ReadLine();

            
            char[] sarray = word.ToCharArray();
          
            string reversedstring = "";
            for (int i = sarray.Length - 1; i >= 0; i--)
                {
                    reversedstring = reversedstring + sarray[i];

                }
            reversedstring = reversedstring.ToLower();
            word = word.ToLower();
            if (reversedstring == word)
                {
                     Console.WriteLine( word + " is palindrome");
                }
            else
                {
                     Console.WriteLine(word + " in not palindrome");
                }
            Console.ReadLine();
        }

    }
}