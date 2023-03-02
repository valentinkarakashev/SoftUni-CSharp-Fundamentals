﻿namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = new string(name.Reverse().ToArray());
            int tryCount = 0;

            while (true)
            {
                string nameTry = Console.ReadLine();

                tryCount++;

                if (tryCount > 3 && nameTry != password)
                {
                    Console.WriteLine($"User {name} blocked!");
                    break;
                }

                if (nameTry == password)
                {
                    Console.WriteLine($"User {name} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}