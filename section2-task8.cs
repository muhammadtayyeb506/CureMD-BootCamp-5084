using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a Number!");
        int num = int.Parse(Console.ReadLine());
        for (int i = 2; i <= num; i++)
        {
            bool isPrime = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }
}