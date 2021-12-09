using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Threading;

namespace Lantz_HashTable
{
    class View
    {
        
        
        
        
        public int GetMenuChoice()
        {
            int choice;

            WriteLine("\nGrocery Inventory System");
            WriteLine("\n1. Add an item to the system");
            WriteLine("2. Delete an item from the system by Id ");
            WriteLine("3. Search for an item by Id Number");
            WriteLine("4. Search for an item by name to get Id");
            WriteLine("5. Display all items in Inventory");
            WriteLine("6. Exit the system");

            choice = Convert.ToInt32(ReadLine());
            

            return choice;
        }





    }
}
