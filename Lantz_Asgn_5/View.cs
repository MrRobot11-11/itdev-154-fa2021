using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using static System.Console;
using System.Threading;

namespace Lantz_Asgn_5
{
    public class View
    {
        //Presented to the user
        public int GetMenuChoice()
        {
            int choice;
            WriteLine("\n\n1: Display the contents of our tree, in order");
            WriteLine("2: Add a value to the tree");
            WriteLine("3: Delete a value from the tree");
            WriteLine("4: Exit");

            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        //First thing the user will see
        public void HelloUser()
        {
            WriteLine("Hello User!");
            Thread.Sleep(1800);
            WriteLine("\nThis program will help you create a Binary Search Tree");
            Thread.Sleep(1800);
            WriteLine("\nWe'll be able to create a BST of ANY size!");
            Thread.Sleep(1800);
            WriteLine("\nI'm gonna ask a couple questions first...");
            WriteLine("");
            Thread.Sleep(2200);
            
        }

        public void CurrentValue()
        {
            Write("\nCurrent values in tree: ");
        }


        //Exit message to user
        public void Exit()
        {
            WriteLine("Thanks for hanging out!");
            WriteLine("See you soon!");
        }

    }
}
