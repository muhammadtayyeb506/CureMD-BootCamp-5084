using System;

namespace Section1_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter two Number for sum."); 
            Console.WriteLine("Enter Number 1:"); 
            double num1 = Double.Parse(Console.ReadLine()); // Converting input into Double and Store it in num1
            Console.WriteLine("Enter Number 1:");
            double num2 = Double.Parse(Console.ReadLine());  // Converting input into Double and Store it in num1
            double sum = num1 + num2;
            Console.WriteLine("your sum is  " + sum);
                        
        }
    }
}
