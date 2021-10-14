using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lantz_Asgn_3
{
    class Node
    {


        //Members
        public int data;
        public Node next;

        //Constructor
        public Node(int i)
        {
            data = i;
            next = null;  //Sets next pointer to null...Not sure why?
        }




    }
}
