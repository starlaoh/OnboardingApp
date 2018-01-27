﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, and welcome to our OnBoarding Application");

            var firstName = AskQuestion("What is your first name?");
            Console.WriteLine($"Great! Hi { firstName}!");

            var lastName = AskQuestion("What is your last name?");
            Console.WriteLine($"Great! Hi {firstName}{lastName}");

            Console.ReadLine();
        }


        /// <summary>
        /// Ask question to the user via the console to get a response.
        /// </summary>
        /// <param name="The question to ask the user"></param>
        /// <returns></returns>

        static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}
