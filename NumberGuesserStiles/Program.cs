using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace

namespace NumberGuesserStiles
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Steve Stiles";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            //Get user info
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", input);
        }
    }
}

