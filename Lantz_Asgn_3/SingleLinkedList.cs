using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Lantz_Asgn_3
{
    class SingleLinkedList
    {

            private Node start; //Private member variable called start; will always point to the first node in the list

            public SingleLinkedList() //Constructor that creates a new instance of the list class
            {
                start = null;  //Sets the start node = to null
            }

            public void CreateList()
            {
                int i, n, data;

                Console.WriteLine("Enter the number of nodes: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                    return;

                for (i = 1; i <= n; i++)
                {
                    Console.WriteLine("Enter the element to be inserted: ");
                    data = Convert.ToInt32(Console.ReadLine());
                    InsertAtEnd(data);
                }
                WriteLine("");
                DisplayList();
            }//end of CreateList

            public void InsertAtBeginning(int data) //Insert a new node at the beginning of the linked list
            {
                Node temp = new Node(data); //Create a temporary node
                temp.next = start; //Means we're putting this node at the beginning
                start = temp; //New node is put at the beginning with data
            }

            public void InsertAtEnd(int data)
            {
                Node p;
                Node temp = new Node(data); //New node that we're going to insert

                if (start == null) //Check if we have an empty list
                {
                    start = temp; //If we do have an empty list, just assign start to temp;
                    return;
                }
                p = start; //Get a reference to the start of the list
                while (p.next != null)//Walk the list to the end
                    p = p.next; //Walking the list

                    p.next = temp; //Once we get to the end of the list or p.next points to null, we insert our node
                }

            public void DisplayList()
            {
                if (HasCycle()) //If a cycle is present, will create infinite loop
                {
                    Console.WriteLine("Cycle detected, cannot display list.");
                    return;
                }


                Node p;
                if (start == null) //Check if list is empty
                {
                    Console.WriteLine("List is empty");
                    return;
                }

                p = start;
                Write("Your list: ");
                while (p != null)
                {
                   
                    Console.Write(p.data + " ");
                    p = p.next; //Move to next element in the list
                }
               
                Console.WriteLine(" ");
                
            }

            public void CountNodes()
            {
                int n = 0;
                Node p = start;
                while (p != null)
                {
                    n++;
                    p = p.next;
                }
                Console.WriteLine("The list has " + n + " Nodes");
            }

            public bool Search(int x)
            {
                int position = 1; //Start looking at first element in list
                Node p = start;

                    while (p != null)
                    {
                        if (p.data == x)
                            break;

                        position++;
                        p = p.next;
                    }
                    
                    if (p == null) //If we make it to the end of the list
                    {
                        Console.WriteLine(x + " not found in the list");
                        return false;
                    }

                    else
                    {
                        Console.WriteLine(x + " is at position " + position);
                        return true;
                    }
                
            }

            public void InsertAfter(int data, int x)
            {
                Node p = start;

                while (p != null) //Walking the list
                {
                    if (p.data == x) //Checking if each node is equal to the value of x
                        break;
                    p = p.next;

                }

                if (p == null)
                    Console.WriteLine(x + " is not present in the list");

                else
                {
                    Node temp = new Node(data); //Create a temporary node with data that was passed in
                    temp.next = p.next; //Basically these 2 lines insert node after the node we just found
                    p.next = temp;
                }
            }

            public void InsertBefore(int data, int x)
            {
                Node temp;

                //Check to see if we have an empty list
                if (start == null)
                {
                    Console.WriteLine("The list is empty");
                    return;
                }

                //Check if x is first node
                if (x == start.data)
                {
                    InsertAtBeginning(data); //If x is first node, insert data before first node
                }

                //Get predecessor node
                Node p = start;

                while (p.next != null)
                {
                    if (p.next.data == x)// If find x, won't be pointing at that node, it will be pointing at predecessor node
                        break;
                    p = p.next;
                }

                if (p.next == null) //Didn't find x
                    Console.WriteLine(x + " is not present in the list.");

                else
                {
                    temp = new Node(data); //This code basically inserts node before node that contains x
                    temp.next = p.next;
                    p.next = temp;
                }
            }// End of insert before

            public void InsertAtPosition(int data, int k)
            {
                Node temp;
                int i;

                if (k == 1)  //User wants to insert at position 1
                {
                    InsertAtBeginning(data);
                }

                Node p = start;
                //Get reference to the node prior
                for (i = 1; i < k - 1 && p != null; i++)  //Get reference to node prior
                {
                    p = p.next;
                }

                if (p == null) //Make it to the end and haven't found the position that we're looking for
                    Console.WriteLine("That position is past the end of the list. \nYou can only insert upt to the " + i + "th position");
                else
                {
                    temp = new Node(data);
                    temp.next = p.next;
                    p.next = temp;
                }
            }//End of InsertAtPosition

            public void DeleteFirstNode()
            {
                if (start == null) //Check if empty list
                    return;
                start = start.next; //Basically just change the point to the next node and nothing points to the first node anymore
            }

            public void DeleteLastNode()
            {
                if (start == null) //Check if empty list
                    return;

                if (start.next == null) //If we're in a list with only 1 node, left with one node
                {
                    start = null;
                    return;
                }

                Node p = start;
                while (p.next.next != null) //Looking 2 ahead; we don't end on last node, we end on 2nd to last node
                    p = p.next; //Now we're sitting on 2nd to last node
                p.next = null; //Because we're not on last node, we change the pointer to delete the last node
            }

            public void DeleteNodeWithValue(int x)
            {
                if (start == null)
                {
                    Console.WriteLine("The list is empty");
                    return;
                }

                //x is found in the first node
                if (start.data == x)
                {
                    DeleteFirstNode(); //Change pointer from first node to second, basically removing the first node
                }

                //x is found elsewhere in the list
                Node p = start;

                while (p.next != null)
                {
                    if (p.next.data == x)
                        break;
                    p = p.next; //Walk forward down the list to see if we find x; looking 1 ahead
                }

                if (p.next == null) //Not found
                    Console.WriteLine(x + " is not found in the list");

                else
                {
                    p.next = p.next.next; //Rewire pointers to remove the node with the value of x
                }
            }//End of DeleteNodeWithValue

            public void ReverseList()
            {
                Node previous;
                Node current;
                Node next;

                previous = null;
                current = start;  //Set to the start of the list

                while (current != null) //Walks list until current does not = null
                {
                    //See screenshot for how this works; vid 07: 1:32
                    next = current.next;  //sets next equal to the 2nd node
                    current.next = previous;  //What current.next is pointing to gets re-routed to what previous is
                                              //On the 1st iteration, previous is = to null
                    previous = current; //Makes previous point to what current is pointing to, which is start on the 1st iteration
                    current = next; //Current gets moved to what next is pointing to; which on the 1st iteration is the 2nd node
                }

                start = previous;
            }

            public void BubbleSortData()
            {
                Node end, p, q;
                int passCount = 0;

                for (end = null; end != start.next; end = p)
                {
                    for (p = start; p.next != end; p = p.next)
                    {
                        q = p.next;
                        if (p.data > q.data) //if yes, moves into codeblock
                        {                   //Basically compare each node to the next; 
                                            //If p is larger, they swap places
                                            //if not, move to next pass
                            int tempData = p.data;//p = start at first pass
                            p.data = q.data;
                            q.data = tempData;
                        }
                    }
                    passCount++;
                    Console.WriteLine("List after pass " + passCount);
                    DisplayList();
                }
            }

            public void BubbleSortLinks()// Instead of swapping data, we're swapping pointers(links)
                                         //Sorts data to be in order
                                         // What is use case for this?
            {
                Node end, r, p, q, temp;
                int passcount = 0;

                for (end = null; end != start.next; end = p)
                {
                    for (r = p = start; p.next != end; r = p, p = p.next)
                    {
                        q = p.next; //setting q = to p.next; p is always our current node
                        if (p.data > q.data)
                        {
                            p.next = q.next;//if data is larger then, swap pointers 
                            q.next = p;
                            if (p != start)
                                r.next = q;
                            else
                                start = q;

                            temp = p;
                            p = q;
                            q = temp;
                        }
                    }
                    passcount++;
                }
            }

            public void InsertCycle(int x) //Value of the node.data where they want to insert cycle
            {
                //Check if we're in an empty list
                if (start == null)
                    return;

                Node p = start;
                Node px = null;
                Node previous = null;

                while (p != null) //Start walking the list
                {
                    if (p.data == x)
                        px = p; // If it finds x, creates px pointer, and points to where p was, which is = to x
                    previous = p; //Previous starts out as null, if we don't find x, it = p, which means it points to the start
                    p = p.next;  //P moves to the next node looking for x;
                                 // Keeps walking the list until p = null bc that is how the while loop is setup
                                 // But, we have px = to where the data = to x is
                }

                if (px != null) //If we found x, set previous.next = px, px being the node where x is located
                {
                    previous.next = px; //At this point, bc we're at the end of the list and px isn't null, previous.next was pointing to the end of the list or null
                                        //Now it's going to point to where we found x
                    Console.WriteLine("Cycle inserted at node with value " + x);
                }
                else
                    Console.WriteLine(x + " is not present in the list.");
            }

            public bool HasCycle()
            {
                if (FindCycle() != null)
                    return true;

                else
                    return false;
            }

            public Node FindCycle() // Called tortoise and hare algorithm 
            {
                //Check for empty list or list w/ only 1 node
                if (start == null || start.next == null)
                    return null;

                //Create two nodes, 1 fast, 1 slow
                Node tortoise, hare;

                //Put them both on the starting line
                tortoise = start;
                hare = start;

                //Testing fast one; If it was not a cycle, hare would hit a null value
                while (hare != null && hare.next != null)  // If they ever equal each other, you know you have a cycle
                {
                    tortoise = tortoise.next; //Move 1 step
                    hare = hare.next.next; // Move 2 steps
                    if (tortoise == hare) // Found cycle; if they match each other, means a cycle is present
                        return tortoise;//Return point at which they equal each other
                }

            // Didn't find cycle
                //WriteLine("Cycle not found.");
                return null;
                
            }

            public void RemoveCycle()
            {
                Node cycleFound = FindCycle(); //Find the place where cycle occurs; where T & H meet
                                               //Where they detect cycle is not where node is pointing
                if (cycleFound == null) //No cycle
                {
                    WriteLine("No cycle found.");
                    return;
                }
            
                Console.WriteLine("Cycle detected at node with value: " + cycleFound.data);

                //Find the length of the cycle
                Node p = cycleFound;
                Node q = cycleFound;

                int cycleLength = 0;

                do
                {
                    cycleLength++;
                    q = q.next; //Counting around cycle until reach point at which we found it
                                //Where they equal each other, cycleLength has incremented how long the cycle is
                } while (p != q);
                Console.WriteLine("The cycle is " + cycleLength + " nodes long.");

                //Find the length of the remaining list
                int remainingListLength = 0;
                p = start;

                while (p != q)
                {
                    remainingListLength++; //Tells us how long rest of list is
                    p = p.next;
                    q = q.next;
                }
                Console.WriteLine("The remaining list is " + remainingListLength + " nodes long.");

                //The total list is the sum of the cycle length and the remaining list length
                int listLength = cycleLength + remainingListLength;
                Console.WriteLine("The whole list is " + listLength + " nodes long.");

                //Walk the list and reassign next pointer on each node
                p = start;

                for (int i = 1; i <= listLength - 1; i++)
                {
                    Console.WriteLine("Reassigning Node: [" + p.data + "].Next -> Node: [" + p.next.data + "]");
                    p = p.next; //p will end up at last node
                }

                //Set the next pointer on the last node to be null
                Console.WriteLine("Reassigning Node: [" + p.data + "].Next -> null to terminate list.");
                p.next = null; //sets p pointer to null, from above
                Console.WriteLine("Cycle removed.");

            }


       


    }//End of class
}
