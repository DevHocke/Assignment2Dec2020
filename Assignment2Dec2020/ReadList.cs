using System;
using System.Collections.Generic;

namespace Assignment2Dec2020
{
    class ReadList
    {
        // The method Listmembers uses a foreach loop to list a index nr and the name of the members.
        public static void ListMembers(List<Members> myMembers)
        {
            int index = 1;
            Console.Clear();
            Console.WriteLine("These are the members from Norrlänningarna: ");
            foreach (var item in myMembers)
            {
                Console.WriteLine($"{index} {item.name}, ");
                index++;
            }
        }

        // The method ListmembersDetails lets the user choose wich member to view in detail.
        public static void ListMembersDetails(List<Members> myMembers)
        {
            int answer;
            ListMembers(myMembers);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Which one do you want to know more about? ");
            string checkIfNumb = Console.ReadLine();

            if (int.TryParse(checkIfNumb, out answer))
            {
                Console.Clear();
                for (int i = 0; i < myMembers.Count; i++)
                {
                    if (answer == i)
                    {
                        myMembers[i - 1].DetailedMember();
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please use a single digit number.");
            }
        }

        // This Method asks the user what member to remove from the members list before it returns back to the main menu.
        public static void RemoveMember(List<Members> myMembers)
        {
            int answer;
            ListMembers(myMembers);
            
            Console.WriteLine($"What member do you want to remove?");
            string checkIfNumb = Console.ReadLine();
            
            if (int.TryParse(checkIfNumb, out answer))
            {
                myMembers.RemoveAt(answer - 1);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid input, please use a single digit number.");
            }
        }
    }
}
