using System;


namespace Section1_task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i= 2; i <=100; i=i+2)
            // To begin, we assign the number 2 to 'i.'
            // Then, to keep 'i' below 100, we define a restriction.
            // Moreover,during each iteration of the loop, we increment 'i' by 2.
            {
                Console.WriteLine(i);
            }
        }
    }
}
