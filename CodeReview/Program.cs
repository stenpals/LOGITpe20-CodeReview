﻿using System;

namespace CodeReview
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks the user's name and greets the user by their name
             */
            Console.WriteLine("What's your name?");
            string Name;
            Name = Console.ReadLine();
            Console.WriteLine("Hello, "+ Name);
        }
    }
}
