using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespaces
namespace ConsoleApp1
{
    //main class
    class Program
    {
        //entry point method
        static void Main(string[] args)
        {
            //Set app variabler
            string appName = "Number Guesseer";
            string appVersion = "1.0.0";
            string appAuthor = "Anna Larsson";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            // Reset text color
            Console.ResetColor();

            //Ask for users name
            Console.WriteLine("Whats your name?");
            //input name
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome {0}, Let's play a game.....", userName);

            //init correct number
            int correctNumber = 7;

            // init guess var
            int guess = 0;
            //ask user for a number
            Console.WriteLine("Guess a number between 0 and 10?");


            // while guess is not correct
            while (guess != correctNumber)
            {
                //get users input
                string input = Console.ReadLine();
             if(!int.TryParse(input,out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter an actual number!");
                    Console.ResetColor();
                    continue;
                   
                }

                guess = Int32.Parse(input);
                // match gusess to correctNumber
                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Try again!");
                    Console.ResetColor();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Wohoo right number {0}!", userName);
                    Console.ResetColor();
                    Console.ReadKey();



                }
            }
        }
    }
} 
      
