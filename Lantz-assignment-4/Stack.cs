using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lantz_assignment_4
{
    class Stack
    {
        private int[] stackArray;
        private int top; //Integer that points to top of array

        //Default constructor; creates array w/ 10 elements
        public Stack()
        {
            
            stackArray = new int[5];
            top = -1; //When inspect a stack and the value is -1, means empty
        }

        //Constructor that creates array size based on user input
        public Stack(int maxSize)
        {
            stackArray = new int[maxSize];
            top = -1;
        }

        //Returning how big the array is
        public int Size()
        {
            return top + 1;
        }

        //Check if array is empty
        public bool isEmtpy()
        {
            return (top == -1);
        }

        //Check if array is full
        public bool isFull()
        {
            return (top == stackArray.Length - 1);
        }

        //Push is taking top element of array and pushing it down with a new one
        public void Push(int x)
        {
            if (isFull())
               throw new System.InvalidOperationException("Stack Overflow");

            top += 1;
            stackArray[top] = x;
            
        }

        public int Pop()
        {
            int x;

            if (isEmtpy())
                throw new System.InvalidOperationException("Stack Underflow");

            x = stackArray[top];
            top -= 1;

            return x;
        }

        public int Peek()
        {
            if (isEmtpy())
                throw new System.InvalidOperationException("Stack Underflow");

            return stackArray[top];
        }

        public void Display()
        {
            if (isEmtpy())
            {
                WriteLine("Stack is Empty");
                return;
            }

            WriteLine("The stack is: ");
            for (int i = top; i >= 0; i--)
            {
                WriteLine(stackArray[i] + " ");
            }
            
            WriteLine();
        }
        
        public void DisplayTop()
        {
            WriteLine("Top is currently: " + top);
        }
    


    }//End of class
}//End of namespace
