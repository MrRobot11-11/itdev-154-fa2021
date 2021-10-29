using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lantz_assignment_4
{
    class Queue
    {
        private static int front, back, capacity = 5;
        private static int[] queueArray;

        //Constructor to set values
        public Queue()
        {
            front = back = 0;
            queueArray = new int[capacity];
        }
    
        //Method to insert an element at the rear of the queue
        public void QueueEnqueue(int data)
        {
            //Check if queue is full
            if(capacity == back)
            {
                Write("\nQueue is full\n");
                return;
            }

            //Insert element at the back of queue
            else
            {
                queueArray[back] = data;
                back++;
            }
            return;
        }
    
        //Method to delete an element from the front of the queue
        public int QueueDequeue()
        {
            int x;
            x = QueueFront();
            
            //If queue is empty
            if (front == back)
                throw new System.InvalidOperationException("Queue is empty");

            //Shift all elements from index 2 till back to the right by one
                for (int i = 0; i < back; i++)
                    queueArray[i] = queueArray[i + 1];

                //Store 0 at back indicating there's no element
                if (back < capacity)
                    queueArray[back] = 0;

                back--;
            
            return x;
        }
    
        //Method to display all elements in the Queue
        public void QueueDisplay()
        {
            if(front == back)
            {
                WriteLine("\nQueue is empty");
                return;
            }

            //Traverse front to rear and print elements
            for (int i = front; i < capacity; i++)
                Write(" {0} <-- ", queueArray[i]);
                WriteLine();

            return;
        }
    
        //Show front of Queue
        public int QueueFront()
        {
        //Check if queue is empty
            if(front == back)
                throw new System.InvalidOperationException("Queue is empty");
            

            return queueArray[front];
        }

        //Show number of elements in the queue
        public int QueueSize()
        {
            return back ;
        }
    
    
    
    }//End of class
}
