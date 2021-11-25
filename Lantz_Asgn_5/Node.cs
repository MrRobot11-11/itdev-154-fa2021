using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using static System.Console;

namespace Lantz_Asgn_5
{
    public class Node
    {
         public int data;
         public Node left, right;

        //Constructor to initialize values
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}
