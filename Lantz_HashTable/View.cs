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

            WriteLine("Grocery Inventory System");
            WriteLine("\n1. Add an item to the system");
            WriteLine("2. Delete an item from the system ");
            WriteLine("3. Search for an item by Id Number");
            WriteLine("4. Display all items in Inventory");
            WriteLine("5. Exit the system");

            choice = Convert.ToInt32(ReadLine());

            return choice;
        }





    }
}
