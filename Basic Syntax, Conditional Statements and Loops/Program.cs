﻿namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); 

            while (true)
            {
                if (number % 2 == 0 && number >= 0)
                {
                    Console.WriteLine($"The number is: {number}");
                    break;
                }
                else if (number % 2 == 0 && number < 0)
                {
                    Console.WriteLine($"The number is: {number * -1}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }

                number = int.Parse(Console.ReadLine());
            }
        }
    }
}