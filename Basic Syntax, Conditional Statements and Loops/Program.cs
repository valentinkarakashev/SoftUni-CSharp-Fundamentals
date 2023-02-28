﻿namespace _4._Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int hoursToMinutes = hours * 60;
            int allMinutes = hoursToMinutes + minutes + 30;

            int realHours = allMinutes / 60;
            int realMinutes = allMinutes % 60;


            if (realMinutes < 10)
            {
                if (realHours > 23)
                {
                    Console.WriteLine($"0:0{realMinutes}");
                }
                else
                {
                    Console.WriteLine($"{realHours}:0{realMinutes}");
                }
            }
            else
            {
                if (realHours > 23)
                {
                    Console.WriteLine($"0:{realMinutes}");
                }
                else
                {
                    Console.WriteLine($"{realHours}:{realMinutes}");
                }
            }
        }
    }
}