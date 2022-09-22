﻿using System;
using AbstractExample.Models;

namespace AbstractExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Which animal do you want to hear?");
            var choice = Console.ReadLine();

            Animal animal = null;

            if (choice == "1")
            {
                animal = new Snake();
            }
            else if (choice == "2")
            {
                animal = new Snake();
            }

            animal?.MakeNoise();
            animal?.Sleep();
        }
    }
}
