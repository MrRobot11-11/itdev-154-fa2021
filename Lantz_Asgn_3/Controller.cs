using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace Lantz_Asgn_3
{
    class Controller
    {
        //Runs the main part of the program
        public static void RunProgram()
        {
            int choice, data, k, x;

            SingleLinkedList list = new SingleLinkedList();

            list.CreateList(); //Asking user to create list

            while (true)
            {
                choice = GetMenuChoice(); //Shows menu to user and returns int 

                if (choice == 18)
                    break;

                switch (choice)
                {
                    case 1: //Display the list
                        WriteLine("");
                        list.DisplayList();
                        break;

                    case 2: //Count the Nodes
                        list.CountNodes();
                        break;

                    case 3: //Search for a Node with a specific value
                        WriteLine("Which integer are you looking for? ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Search(data);
                        break;

                    case 4: //Insert into empty list
                        Console.WriteLine("Enter an integer value to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBeginning(data);
                        list.DisplayList();
                        break;

                    case 5: //Insert at the end of the list
                        Console.WriteLine("Enter an integer value to be inserted");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(data);
                        list.DisplayList();
                        break;

                    case 6: //Insert after a specified node
                        Console.WriteLine("Enter an integer value to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the value of the Node to be inserted after: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(data, k);
                        list.DisplayList();
                        break;

                    case 7: //Insert before a specified node
                        Console.WriteLine("Enter an integer value to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the value of the Node to be inserted Before: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(data, k);
                        list.DisplayList();
                        break;

                    case 8: //Insert at specific position
                        Console.WriteLine("Enter an integer value to be inserted: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the position where you want to insert the Node: ");
                        k = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(data, k);
                        list.DisplayList();
                        break;

                    case 9: //Delete the first node
                        list.DeleteFirstNode();
                        Console.WriteLine("First node deleted.");
                        list.DisplayList();
                        break;

                    case 10: //Delete the last node
                        list.DeleteLastNode();
                        Console.WriteLine("Last node deleted.");
                        list.DisplayList();
                        break;

                    case 11: //Delete node with a specific value
                        Console.WriteLine("Enter an integer value to search for and delete: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNodeWithValue(data);
                        list.DisplayList();
                        break;

                    case 12: //Reverse the list
                        list.ReverseList();
                        Console.WriteLine("List reversed.");
                        list.DisplayList();
                        break;

                    case 13: // Bubble sort by exchanging data
                        list.BubbleSortData();
                        WriteLine("List Sorted.");
                        list.DisplayList();
                        break;

                    case 14: //Bubble sort by exchanging links
                        list.BubbleSortLinks();
                        Console.WriteLine("List sorted.");
                        list.DisplayList();
                        break;

                    case 15: //Insert a cycle
                        Console.WriteLine("Enter an integer value to search for and insert a cycle at: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.InsertCycle(data);
                        break;

                    case 16: //Detect cycle
                        if (list.FindCycle() != null)
                            Console.WriteLine("Cycle detected at node with value: " +
                                list.FindCycle().data.ToString());
                        else
                            Console.WriteLine("No cycle detected.");
                        break;

                    case 17: //Remove Cycle
                        list.RemoveCycle();
                        break;

                    case 18: //Quit
                        break;

                    default:
                        Console.Write("You chose poorly.");
                        Thread.Sleep(900);
                        Write(".");
                        Thread.Sleep(900);
                        Write(".");
                        Thread.Sleep(900);
                        WriteLine(" ");
                        WriteLine(" ");
                        Write("Goodbye.");
                        Thread.Sleep(900);
                        Write(".");
                        Thread.Sleep(900);
                        Write(".");
                        Thread.Sleep(900);
                        Environment.Exit(0);
                        break;
                }
            }









        }//End of RunProgram

        //Don't worry about input validation
        private static int GetMenuChoice()
        {
            int choice;
            Console.WriteLine("");
            Console.WriteLine("1 - Display List");
            Console.WriteLine("2 - Count Nodes");
            Console.WriteLine("3 - Search");
            Console.WriteLine("4 - Insert In Empty List");
            Console.WriteLine("5 - Insert At End");
            Console.WriteLine("6 - Insert After Specified Node");
            Console.WriteLine("7 - Insert Before Specified Node");
            Console.WriteLine("8 - Insert at Position");
            Console.WriteLine("9 - Delete First Node");
            Console.WriteLine("10 - Delete Last Node");
            Console.WriteLine("11 - Delete Node with Value");
            Console.WriteLine("12 - Reverse the List");
            Console.WriteLine("13 - Bubble Sort by Exchanging Data");
            Console.WriteLine("14 - Bubble Sort by Exchanging Links");
            Console.WriteLine("15 - Insert Cycle");
            Console.WriteLine("16 - Detect Cycle");
            Console.WriteLine("17 - Remove Cycle");
            Console.WriteLine("18 - Quit");
            Console.WriteLine("Choose Wisely...");
            Console.WriteLine("");

            choice = Convert.ToInt32(Console.ReadLine());
            return choice;

        }//End of getMenuChoice








    }//End of class
}
