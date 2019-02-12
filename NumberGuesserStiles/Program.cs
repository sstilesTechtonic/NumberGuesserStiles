﻿using System;
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
            GetAppInfo();

            GreetUser();

            while (true)
            {

                //Set correct number
                //int correctNumber = 7;

                //Random number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess variable
                int guess = 0;

                // Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    // Users input
                    string input = Console.ReadLine();

                    //Number catch
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number");

                        // Keep going
                        continue;
                    }

                    //Cast to int and put in guess variable
                    guess = Int32.Parse(input);

                    //Match guess to number
                    if (guess != correctNumber)
                    {

                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!");
                    }
                }

                //Output success
                PrintColorMessage(ConsoleColor.Yellow, "You are a winner!");

                Console.WriteLine("Play Again? (Y or N)");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                }
                else if(answer == "N"){
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo() {
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
        }

        static void GreetUser(){
            // Ask users name
            Console.WriteLine("What is your name?");

            //Get user info
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message){
            //Change text color
            Console.ForegroundColor = color;

            // Wrong number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }

    }
}

