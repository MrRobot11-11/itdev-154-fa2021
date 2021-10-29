using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lantz_assignment_4
{
    class View
    {
    //Ask user if they want to create a stack or a queue
        public int GetArrayType()
        {
            int choice;
            WriteLine("Please choose either 1 or 2\n");
            WriteLine("1. Create a Stack Array");
            WriteLine("2. Create a Queue Array");
            WriteLine("6. Leave program");
            WriteLine("\nEach array will be created with 5 spaces for elements\n");
            
            choice = Convert.ToInt32(ReadLine());
            WriteLine();
            return choice;
        }

        //Method to show a queue menu or a stack menu
        public int Menu(string typeOfArray)
        {
            int choice;

            Write(typeOfArray);
            WriteLine("6. Leave program\n");
            
            choice = Convert.ToInt32(ReadLine());
            WriteLine();
            return choice;
        }
        
        
        /*Originally I had 2 separate menus
        public int QueueMenu()
        {
            int choice;

            WriteLine("1. Add to the queue");
            WriteLine("2. Delete an element from the front of the queue");
            WriteLine("3. Show element at front of queue");
            WriteLine("4. Display entire queue");
            WriteLine("5. Number of elements in the stack");
            WriteLine("6. Leave program");

            choice = Convert.ToInt32(ReadLine());
            WriteLine();
            return choice;
        }
        */
        
    }
}
