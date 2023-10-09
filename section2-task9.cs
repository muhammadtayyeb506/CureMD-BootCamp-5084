using System;


namespace Section2_task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Number!");
            int num = int.Parse(Console.ReadLine());
            int j = 1;
            for (int i = 1; i <= num; i++)
            {
                int sum = i * j;
                j = sum;
            }
            Console.WriteLine("Factorial of " + num + " is " + j);
            Console.ReadLine();
        }
    }
}
