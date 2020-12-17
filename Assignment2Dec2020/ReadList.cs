﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Inlämning2_trial1
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
            answer = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < myMembers.Count; i++)
            {
                if (answer == i)
                {
                    myMembers[i - 1].DetailedMember();
                }
            }
        }

        // This Method asks the user what member to remove from the members list before it returns back to the main menu.
        public static void RemoveMember(List<Members> myMembers)
        {
            int index = 1;
            Console.WriteLine("These are the members from Norrlänningarna: ");
            foreach (var item in myMembers)
            {
                Console.WriteLine($"{index} {item.name}, ");
                index++;
            }
            Console.WriteLine($"What member do you want to remove?");
            int answer = Convert.ToInt32(Console.ReadLine());
            myMembers.RemoveAt(answer - 1);
            Console.Clear();
        }
    }
}
