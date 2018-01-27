using System;
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
            var User = new User();

            Console.WriteLine("Hello, and welcome to our OnBoarding Application");

            User.FirstName = AskQuestion("What is your first name?");
            Console.WriteLine($"Great! Hi { User.FirstName}!");

            User.LastName = AskQuestion("What is your last name?");
            Console.WriteLine($"Great! Hi {User.FullName}!");

            User.IsAccountOwner = AskBoolQuestion("Are you the account owner?");
            Console.WriteLine("Cool, good to know.");
            
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
        /// <summary>
        /// Ask a T/F question to a user via the console and get response
        /// <param name="question to ask user"></param>
        /// <returns>user is required to type y or n</returns>
 
        static bool AskBoolQuestion(string question)
        {
            while (true)
            {
                var response = AskQuestion(question + "| (y/n)");
                switch (response.ToLower())
                {
                    case "y": return true;
                    case "n": return false;
                }
                Console.WriteLine("Invalid entry. Please type y or n.");
                // return response == "y";
            }
        }
    }
}
