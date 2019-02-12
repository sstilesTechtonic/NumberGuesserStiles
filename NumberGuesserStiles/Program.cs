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
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            //Set correct number
            int correctNumber = 7;

            // Init guess variable
            int guess = 0;

            // Ask user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            while(guess != correctNumber) {
                // Users input
                string input = Console.ReadLine();

                //Cast to int and put in guess variable
                guess = Int32.Parse(input);

                //Match guess to number
                if(guess != correctNumber){
                    //Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Wrong number
                    Console.WriteLine("Wrong number, please try again!");

                    //Reset text color
                    Console.ResetColor();
                }
            }

            //Output success
            //Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Right number
            Console.WriteLine("You are a winner!");

            //Reset text color
            Console.ResetColor();

        }
    }
}

