using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace Lantz_assignment_4
{
    class Controller
    {
        public void RunProgram()
        {
            int choice, input;
            bool loopControl = true;
            string typeOfArray = " "; //Queue or stack
            
            string stackMenu = "1. Add to the stack\n" +
                            "2. Pop from the stack\n" +
                            "3. Peek at the top element\n" +
                            "4. Display entire stack\n" +
                            "5. Number of elements in the stack\n";
            
            string queueMenu = "1. Add to the queue\n" +
                               "2. Delete an element from the front of the queue\n" + 
                               "3. Show element at front of queue\n" + 
                               "4. Display entire queue\n" + 
                               "5. Number of elements in the queue\n";
            string menu = " ";
                                
            Stack stack = new();
            View view = new();
            Queue q = new();
            
            try
            {   
                //First we ask the user what type of array to create: stack/queue
                    choice = view.GetArrayType();
                
                while (loopControl)
                 {
                
                //Assign values; show user correct menu
                    if (choice == 1) 
                        {
                            typeOfArray = "stack";
                            menu = stackMenu;
                        }   
                    if (choice == 2)
                        {
                            typeOfArray = "queue";
                            menu = queueMenu;
                        }
                    if (choice == 6)
                        {
                            WriteLine("Goodbye...");
                            break;
                        }

                 /*Once we have what the user wants to create(stack/queue),
                    pass that value to the menu so it's displayed properly*/
                        switch (view.Menu(menu))
                        {
                            case 1:
                                WriteLine("What would you like to put on the {0}?\n", typeOfArray);
                                input = Convert.ToInt32(ReadLine());
                            
                        //Nested switch; corresponds to array type
                                switch (choice)
                                {
                                    case 1:
                                        stack.Push(input);
                                        WriteLine();
                                        break;

                                    case 2:
                                        q.QueueEnqueue(input);
                                        WriteLine();
                                        break;
                                }
                                break;

                            case 2:
                                switch (choice)
                                {
                                    case 1:
                                        input = stack.Pop();
                                        WriteLine("You popped " + input + " off the stack\n");
                                        break;

                                    case 2:
                                        input = q.QueueDequeue();//Remove element from front of queue
                                        WriteLine("You removed {0} from the queue\n", input);
                                        break;
                                }
                                break;
                            
                            case 3:
                                switch (choice)
                                {
                                    case 1:
                                        WriteLine("You peeked at the top element which is: " + stack.Peek() + "\n");
                                        break;

                                    case 2:
                                        WriteLine("You peeked at the front element which is: " + q.QueueFront() + "\n");
                                        break;
                                }
                                break;
                            
                            case 4:
                                switch (choice)
                                {
                                    case 1:
                                        stack.Display();
                                        WriteLine();
                                        break;

                                    case 2:
                                        q.QueueDisplay();
                                        WriteLine();
                                        break;
                                }
                            break;
                                
                            case 5:
                                switch (choice)
                                {
                                    case 1:
                                        WriteLine("Your stack has " + stack.Size() + " elements\n");
                                        break;

                                    case 2:
                                        WriteLine("Your queue has " + q.QueueSize() + " elements\n");
                                        break;
                                }
                                break;
                                
                            case 6:                                 
                                loopControl = false;
                                WriteLine("Goodbye");
                                break;

                            default:
                                loopControl = false;
                                WriteLine("Goodbye");
                                break;
                        }                    
                    }//End of while
                }
                catch (Exception e)
                {
                    WriteLine("An error has occured.\n" + e.Message + "\n" + e.StackTrace);               
                }


            //WriteLine("Broke out the while");
            Read();
        }//End of RunProgram
    }//End of class
}
