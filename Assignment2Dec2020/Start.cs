using System;
using System.Collections.Generic;
using System.Threading;

namespace Assignment2Dec2020
{
    class Start
    {
        public static List<Members> myMembers = new List<Members>();
        // This method is where the user ends up after doing a successfull login.
        // The menu lets the user List the members in case 1 wich starts the method ListMembers in the ReadList class.
        // the user can also choose to go into more deatails about a member by pressing 2 wich starts the method ListMembersDetails in the ReadList class.
        public static void StartProgram()
        {
            MembersAdd.AddMembers(myMembers);
            do
            {
                Console.WriteLine("Welcome to Norrlänningarna! ");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. List the groups members");
                Console.WriteLine("2. List details about a member");
                Console.WriteLine("3. Remove a member");
                Console.WriteLine("4. Quit");
                int menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        ReadList.ListMembers(myMembers);
                        break;
                    case 2:
                        ReadList.ListMembersDetails(myMembers);
                        break;
                    case 3:
                        ReadList.RemoveMember(myMembers);
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Program exits welcome back.");
                        Thread.Sleep(2500);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }
    }
}
