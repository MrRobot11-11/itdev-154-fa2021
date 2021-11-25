using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;
using static System.Console;

namespace Lantz_Asgn_5
{
    public class BinarySearchTree
    {
       
        public Node root; //Pointer that points to root of BST
        public View vw = new View();

//Constructor to set root to null
       public BinarySearchTree()
        {
            root = null;
        }
        
//Ask user to create a tree with (n) number of nodes
        public void CreateTree()
        {
            int i, n, data;
            
            WriteLine("\nEnter the number of nodes you would like to create: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter the element to be inserted: ");
                data = Convert.ToInt32(Console.ReadLine());
                root = Insert(root, data);
            }
            WriteLine("");
            WriteLine("\nThis is the tree we created!");
            vw.CurrentValue();
            InOrder(root);

        }
//Create new node
        public Node NewNode(int item)
        {
            Node temp = new Node(item);
            return temp;
        }
       
      
//Recursive function to do in order traversal of BST
        public void InOrder(Node root)
        {
                //Base case when root becomes null
                    //When we reach end of tree
                if(root != null) 
                {
                    InOrder(root.left);
                    Write(root.data + " ");
                    InOrder(root.right);
                }
        }
        
        //Recursive function to insert a new node w/ given key in BST
        public Node Insert(Node node, int key)
        {
            //If the tree is empty, return a new node
            if (node == null) 
                return NewNode(key);

            //If tree is not empty
            if (key < node.data)
                node.left = Insert(node.left, key);
            else
                node.right = Insert(node.right, key);

            //Return the (unchanged) node pointer
            return node;
        }

/* Given a binary search tree and a key, this
* recursive function deletes the key and returns the
* new root
*/
        public Node DeleteNode(Node root, int data)
        {
            //Base case
            if (root == null)
                return root;
            
            // Recursive calls for ancestors of
            // node to be deleted
            if (root.data > data)
            {
                root.left = DeleteNode(root.left, data);//Continue search in left subtree
                return root;
            }
            else if (root.data < data)
            {
                root.right = DeleteNode(root.right, data);//Continue search in right subtree
                return root;
            }
                
            // If one of the children is empty
            if (root.left == null)
            {
                Node temp = root.right;
                return temp;
            }
            else if (root.right == null)
            {
                Node temp = root.left;
                return temp;
            }

            // If both children exist
            else
            {
                Node succParent = root;

                // Find successor
                Node succ = root.right;

                while (succ.left != null)
                {
                    succParent = succ;
                    succ = succ.left;
                }

                // Delete successor. Since successor
                // is always left child of its parent
                // we can safely make successor's right
                // child as left of its parent.
                // If there is no succ, then assign
                // succ->right to succParent->right
                if (succParent != root)
                    succParent.left = succ.right;
                else
                    succParent.right = succ.right;

                // Copy Successor Data to root
                root.data = succ.data;

                return root;
            }
        }
        



    }//End of class
}//End of namespace
