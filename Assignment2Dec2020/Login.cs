using System;
using System.Threading;

namespace Assignment2Dec2020
{
    class Login
    {
        // The method Password checks if the user input is the same as the constant correctPW, if true it sends the user to,
        // the method StartProgram, if false the variable attempt increments by 1. When the for loop has itterated 3 times, 
        // it exits the program to prevent bruteforce attempts.
        public static void Password()
        {
            // Const is used since the password needs to be constant.
            const string correctPW = "Norrlänningarna";
            int attempt = 0;

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"Attempt {attempt}");
                Console.WriteLine("Enter the top secret password: ");
                string userPW = Console.ReadLine();
                if (userPW == correctPW)
                {
                    Console.WriteLine("Correct Password!");
                    Start.StartProgram();

                }
                else if (userPW == "g" || userPW == "G")
                {
                    Console.WriteLine("Aha so you have god powers do you?");
                    Start.StartProgram();
                }
                else
                {
                    Console.WriteLine("Wrong password! Try again.");
                    attempt++;
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }

            Console.WriteLine("To many attempts. Program Exit.");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }

}
