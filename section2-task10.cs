using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a Number!");
        int num = int.Parse(Console.ReadLine());
        int num1 = 0, num2 = 1;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i <=num; i++)
        {
            Console.WriteLine(num1);
            int sum = num1 + num2;
            num1 = num2;
            num2 = sum;
        }

    }
}
